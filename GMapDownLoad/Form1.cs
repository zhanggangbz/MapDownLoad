using DotNet.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //经纬度信息
        double lon1, lat1, lon2, lat2;
        int zmin=0;
        int zmax=19;

        //数据下载时的标志
        int needflag = 0;
        int complateflag = 1;
        int errorflag = 2;

        Random rd = new Random();
        //谷歌中国卫星地图，有偏移[0123]
        string baseurl = "http://mt{3}.google.cn/maps/vt?lyrs=s%40773&hl=zh-CN&gl=CN&x={0}&y={1}&z={2}";
        //谷歌卫星影像，无偏移[0123]
        //string baseurl = "http://khm{3}.google.com/kh/v=762&hl=zh&x={0}&y={1}&z={2}&s=";
        //基础路径
        string basepath = @"F:/osgearth/data/csharp/wuqi/";
        //基础名称
        string basename = "dt";

        /// <summary>
        /// 获取输入的经纬度
        /// </summary>
        /// <returns></returns>
        private bool initLonlat()
        {
            //西安
            //lon1 = 108.809959;
            //lat1 = 34.152847;
            //lon2 = 109.078258;
            //lat2 = 34.376046;

            //吴起县
            //lon1 = 108.562113;
            //lat1 = 37.419379;
            //lon2 = 107.649612;
            //lat2 = 36.551149;
            try 
            {
                lon1 = double.Parse(this.textBox_s_lon.Text);
                lat1 = double.Parse(this.textBox_s_lat.Text);
                lon2 = double.Parse(this.textBox_e_lon.Text);
                lat2 = double.Parse(this.textBox_e_lat.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 获取并检查输入的基础路径是否存在
        /// </summary>
        /// <returns></returns>
        private bool chackBasePath()
        {
            basename = this.textBox_name.Text;
            basepath = this.textBox_dic.Text;
            if (System.IO.Directory.Exists(basepath) && string.IsNullOrWhiteSpace(basename)==false)
            {
                if (basepath[basepath.Length - 1] != '\\' || basepath[basepath.Length - 1] != '/')
                {
                    basepath += @"\";
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// 检查输入的标识是否合法
        /// </summary>
        /// <returns></returns>
        private bool CheckFlag()
        {
            try
            {
                needflag = int.Parse(this.textBox_need_down.Text);
                complateflag = int.Parse(this.textBox_complate_down.Text);
                errorflag = int.Parse(this.textBox_error_down.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 通过给定的瓦片序号构造瓦片数据地址
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        private string GetTileUrl(int x, int y, int z)
        {
            return string.Format(baseurl, x, y, z,rd.Next(0,4));
        }

        /// <summary>
        /// 检查路径是否存在，如不存在则创建
        /// </summary>
        /// <param name="path"></param>
        private void CheckPath(string path)
        {
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
        }

        /// <summary>
        /// 检查输入的层级索引是否正确
        /// </summary>
        /// <returns></returns>
        private bool CheckZindex()
        {
            zmin = (int)this.numericUpDownSZ.Value;
            zmax = (int)this.numericUpDownEZ.Value;
            if (zmax < zmin)
            {
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chackBasePath() == false)
            {
                MessageBox.Show("输入的路径不存在或名称为空");
                return;
            }
            if (initLonlat() == false)
            {
                MessageBox.Show("输入的经纬度数据不正确");
                return;
            }
            if (CheckFlag() == false)
            {
                MessageBox.Show("输入的标记位数据不正确");
                return;
            }
            if (CheckZindex() == false)
            {
                MessageBox.Show("Z索引输入有误");
                return;
            }

            long countsum = 0;

            //检查并初始化数据库
            DBHelper.CheckDB(basename,basepath);

            List<DiTu_DB> listdata = new List<DiTu_DB>();
            //根据坐标计算每一级别的tmsXY
            for (int z = zmin; z <= zmax; ++z)
            {
                //通过经纬度和层级计算tile坐标
                Point tmstemp1 = TitleClass.WorldToTilePosP(lon1, lat1, z);
                Point tmstemp2 = TitleClass.WorldToTilePosP(lon2, lat2, z);

                Point tmsmax = new Point(Math.Max(tmstemp1.X, tmstemp2.X), Math.Max(tmstemp1.Y, tmstemp2.Y));
                Point tmsmin = new Point(Math.Min(tmstemp1.X, tmstemp2.X), Math.Min(tmstemp1.Y, tmstemp2.Y));
                

                //循环构造tile数据信息，创建相应目录并把tile的xyz写入数据库
                string zpath = basepath + z + @"\";
                for (int x = tmsmin.X; x < tmsmax.X + 1; ++x)
                {
                    string xpath = zpath + x + @"\";
                    CheckPath(xpath);
                    for (int y = tmsmin.Y; y < tmsmax.Y + 1; ++y)
                    {
                        countsum++;
                        DiTu_DB dobj = new DiTu_DB();
                        dobj.id = x.ToString() + y.ToString() + z.ToString();
                        dobj.x = x;
                        dobj.y = y;
                        dobj.z = z;
                        dobj.d = 0;

                        listdata.Add(dobj);
                        if (listdata.Count > 500000)
                        {
                            DBHelper.insertDatasNew(listdata);
                            listdata.Clear();
                        }
                    }
                }
            }

            DBHelper.insertDatas(listdata);

            this.button_init.Text = "已完成" + countsum.ToString();
            listdata.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (chackBasePath() == false)
            {
                MessageBox.Show("输入的路径不存在或名称为空");
                return;
            }
            if (CheckFlag() == false)
            {
                MessageBox.Show("输入的标记位数据不正确");
                return;
            }

            if (chackBasePath() == false)
            {
                MessageBox.Show("输入的路径不存在或名称为空");
                return;
            }

            DBHelper.SetDBPath(basename, basepath);

            timer1.Start();

            backgroundWorker1.RunWorkerAsync();

            this.button_init.Enabled = false;

            this.button_selectDic.Enabled = false;

            this.button_start.Enabled = false;
        }

        int allCount = 0;
        int timeCount = 0;

        private void AddAllCount()
        {
            timeCount++;
            if (label3.InvokeRequired)
            {
                label3.BeginInvoke(
                    new Action(() =>
                    {
                        label3.Text = "已完成" + allCount + "次，耗时" + timeCount * timer1.Interval / 1000 + "秒";
                    })
                );
            }
            else
            {
                label3.Text = "已完成" + allCount + "次，耗时" + timeCount * timer1.Interval / 1000 + "秒";
            }
        }

        public void showLable4(string info)
        {
            if (label4.InvokeRequired)
            {
                label4.BeginInvoke(
                    new Action(() =>
                    {
                        label4.Text = info;
                    })
                );
            }
            else
            {
                label4.Text = info;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AddAllCount();
        }

        /// <summary>
        /// 数据下载的线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //检查数据库中是否还有需要下载的数据
            while (DBHelper.isComplate(this, needflag) != 0)
            {
                //从需要下载的数据中取出10000个数据
                List<DiTu_DB> datas = DBHelper.GetData(10000,needflag);

                //对这10000个数据进行并行处理
                System.Threading.Tasks.Parallel.For(0, datas.Count, (int i) =>
                {
                    //构造下载数据的保存路径
                    string path = basepath + datas[i].z + @"\" + datas[i].x + @"\" + datas[i].y + ".jpg";
                    //构造下载地址
                    string url = GetTileUrl(datas[i].x, datas[i].y, datas[i].z);
                    //下载数据
                    try
                    {
                        using (WebClient webClient = new WebClient())
                        {
                            webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.167 Safari/537.36");
                            webClient.Headers.Add("Accept", "image/webp,image/apng,image/*,*/*;q=0.8");
                            webClient.Headers.Add("Accept-Encoding", "gzip, deflate");
                            webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.9");
                            webClient.Headers.Add("Referer", "http://www.361.me/");
                            webClient.DownloadFile(url, path);
                        }
                        //检查是否下载完成及下载的文件是否合法，并更新数据标记位
                        if (System.IO.File.Exists(path))
                        {
                            System.IO.FileInfo fileInfo = new System.IO.FileInfo(path);
                            if (fileInfo.Length > 0)
                            {
                                datas[i].d = complateflag;
                            }
                            else
                            {
                                datas[i].d = errorflag;
                            }
                        }
                        else
                        {
                            datas[i].d = errorflag;
                        }
                    }
                    catch (Exception ex)
                    {
                        LogHelper.WriteLog(url + "\t" + ex.Message);
                        //Console.WriteLine(url + "\t" + ex.Message);
                        if (datas[i].d != complateflag)
                        {
                            datas[i].d = errorflag;
                        }
                    }
                    //原子操作计数器
                    System.Threading.Interlocked.Increment(ref allCount);
                }
                );
                //批量更新已下载数据的标记位
                DBHelper.updateDatas(datas);
            }

            timer1.Stop();

            this.button_init.Enabled = true;

            this.button_selectDic.Enabled = true;

            this.button_start.Enabled = true;
        }

        private void button_selectDic_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog P_File_Folder = new FolderBrowserDialog();

            if (P_File_Folder.ShowDialog() == DialogResult.OK)
            {
                this.textBox_dic.Text = P_File_Folder.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.AppendText("1.初次使用正确输入路径名称及范围，并初始化任务\n\n");

            this.textBox1.AppendText("2.第一次初始化某个任务时三个标记位不需要修改\n\n");

            this.textBox1.AppendText("3.初始化完毕后，开始下载数据\n\n");

            this.textBox1.AppendText("4.下载完毕后，由于下载数目太多，下载过程中很容易出错，此时调整标记位，把需要下载的标记位的值设置为之前下载错误的标记位的值，同时给下载错误的标记位设置新值\n\n");

            this.textBox1.AppendText("5.继续点击开始下载，把之前下载错误的瓦片数据重新下载一次\n\n");

            this.textBox1.AppendText("6.如下载过程中关机或者关闭程序，再次打开程序后，只需选择之前的路径并输入和之前一样的任务名称后点击开始下载即可\n\n");
        }
    }
}
