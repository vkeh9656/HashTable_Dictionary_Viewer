using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTable_Dictionary_Viewer
{
    public partial class Form1 : Form
    {
        enum enCandidateName
        {
            보검,
            신혜,
            혜성,
            보영,
        }
        
        enum enClassmateName
        {
            진,
            정국,
            RM,
            지민,
            제이홉,
            뷔,
            슈가,
            은비,
            사쿠라,
            혜원,
            예나,
            채연,
            채원,
            민주,
            히토미,
            유리,
            유진,
            원영,
            나코,
        }

        int _iPlayerCount = 0;

        Hashtable _ht = new Hashtable(); // Hashtable의 경우는 Type 선언을 별도로 하지 않아도됨.
        Dictionary<string, string> _dict = new Dictionary<string, string>(); // Dictionary는 Type 선언


        public Form1()
        {
            InitializeComponent();

            //dgListView.Columns.Add("dgKey", "Key"); // column 추가
            //dgListView.Columns.Add("dgValue", "Value"); // column 추가
        }

        private void pBox_Click(object sender, EventArgs e)
        {
            PictureBox pbox = sender as PictureBox;

            string strSelectText = string.Empty;

            switch (pbox.Name)
            {
                case "pBox1":
                    strSelectText = enCandidateName.보검.ToString();
                    break;
                case "pBox2":
                    strSelectText = enCandidateName.신혜.ToString();
                    break;
                case "pBox3":
                    strSelectText = enCandidateName.혜성.ToString();
                    break;
                case "pBox4":
                    strSelectText = enCandidateName.보영.ToString();
                    break;
            }

            int iTotalCount = Enum.GetValues(typeof(enClassmateName)).Length;


            // 진행하는 인원이 마지막 인원이 아닐 경우
            if(iTotalCount > _iPlayerCount)
            {
                enClassmateName enName = (enClassmateName)_iPlayerCount;

                _dict.Add(enName.ToString(), strSelectText);

                UIDisplay(iTotalCount, enName.ToString());

                _iPlayerCount++; // 다음 사람 넘기기
            }
            else
            {
                // 끝났습니다. 메시지
                lblPlayerName.Text = "투표가 완료되었습니다.";
            }
        }

        private void UIDisplay(int iTotalCount, string strPlayerName)
        {
            int iCandidate1 = 0;
            int iCandidate2 = 0;
            int iCandidate3 = 0;
            int iCandidate4 = 0;

            foreach (string item in _dict.Values)
            {
                switch (item)
                {
                    case "보검":
                        iCandidate1++;
                        break;
                    case "신혜":
                        iCandidate2++;
                        break;
                    case "혜성":
                        iCandidate3++;
                        break;
                    case "보영":
                        iCandidate4++;
                        break;
                }
            }

            lblPick1.Text = iCandidate1.ToString();
            lblPick2.Text = iCandidate2.ToString();
            lblPick3.Text = iCandidate3.ToString();
            lblPick4.Text = iCandidate4.ToString();

            // n / m 써주기
            lblTotalCount.Text = string.Format("{0} / {1}", _iPlayerCount + 1, iTotalCount);
            lblPlayerName.Text = strPlayerName;

            DataGridViewComboBoxDisplay();
        }

        private void DataGridViewComboBoxDisplay()
        {
            dgListView.DataSource = _dict.ToArray();

            // DataGridView의 Row Header에 값 적어주기
            foreach(DataGridViewRow oRow in dgListView.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }

            dgListView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
