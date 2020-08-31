using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OneNETSDK;

namespace OneNet_DownLink_Send
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_7886_Click(object sender, EventArgs e)
        {
            tb_imei.Text = "869060030937886";
        }

        private void bt_8082_Click(object sender, EventArgs e)
        {
            tb_imei.Text = "869060030938082";
        }

        private void bt_1_min_Click(object sender, EventArgs e)
        {
            tb_heartbeat.Text = "1";
        }

        private void bt_24_hour_Click(object sender, EventArgs e)
        {
            tb_heartbeat.Text = "720";
        }

        private void bt_lv1_Click(object sender, EventArgs e)
        {
            tb_level.Text = "1";
        }

        private void bt_lv2_Click(object sender, EventArgs e)
        {
            tb_level.Text = "2";
        }

        private void bt_lv3_Click(object sender, EventArgs e)
        {
            tb_level.Text = "3";
        }

        private void bt_lv4_Click(object sender, EventArgs e)
        {
            tb_level.Text = "4";
        }

        private void bt_lv5_Click(object sender, EventArgs e)
        {
            tb_level.Text = "5";
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            tb_imei.Text = string.Empty;
            tb_heartbeat.Text = string.Empty;
            tb_level.Text = string.Empty;
        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            string imei = "";          
            string time = "";
            string level = "";
            string data = "";

            imei = tb_imei.Text;
            time = tb_heartbeat.Text;
            level = tb_level.Text;

            try
            {
                if (imei == string.Empty || level == string.Empty || time == string.Empty)
                {
                    MessageBox.Show("内容不能为空");
                }
                else
                {
                    data = get_time_and_level(time, level);

                    Resources r = new Resources();
                    r.obj_id = 3300;
                    r.obj_inst_id = 0;
                    r.res_id = 5750;

                    OneNET one = new OneNET();
                    one.Write(imei, data, r);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_read_Click(object sender, EventArgs e)
        {
            string data = "00C84E5000050101040001";
            string imei = "";

            imei = tb_imei.Text;

            if(imei == string.Empty)
            {
                MessageBox.Show("IMEI不能为空");
            }
            else
            {
                Resources r = new Resources();
                r.obj_id = 3300;
                r.obj_inst_id = 0;
                r.res_id = 5750;

                OneNET one = new OneNET();
                one.Write(imei, data, r);
            }
        }

        public string get_time_and_level(string time, string level)
        {
            string str = "";
            try
            {
                int i_time = 0;
                int i_level = 0;
                i_time = int.Parse(time);
                i_level = int.Parse(level);

                if (i_time < 1 || i_level > 5 || i_level < 1)
                {
                    return "FFFFFF";
                }

                byte[] b_time = new byte[2];
                byte[] b_level = new byte[1];
                string str_time = "";
                string str_level = "";

                //time  720 to 02D0
                b_time = int2ByteArray(i_time);
                str_time = ByteArrayToString(b_time);


                //level 1 to 01
                b_level[0] = (byte)(i_level & 0xFF);
                str_level = ByteArrayToString(b_level);

                str = "00C84E5000050101040002" + str_time + str_level + "016D190510191110";

                return str;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return str;
        }

        public static byte[] int2ByteArray(int i)
        {
             byte[] result = new byte[2];
             //result[0] = (byte) ((i >> 24) & 0xFF);
             //result[1] = (byte) ((i >> 16) & 0xFF);
             result[0] = (byte) ((i >> 8) & 0xFF);
             result[1] = (byte) (i & 0xFF);
             return result;
        }


        /// <summary>
        /// 将byte型转换为字符串
        /// </summary>
        /// <param name="arrInput">byte型数组</param>
        /// <returns>目标字符串</returns>
        private string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i<arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            //将此实例的值转换为System.String
            return sOutput.ToString();
        }

        //查询
        //00C84E5000050101040001

        //配置1分钟 等级4
        //00C84E5000050101040002000104016D190510191110

        //配置24小时 等级4
        //00C84E500005010104000202D004016D190510191110
    }
}
