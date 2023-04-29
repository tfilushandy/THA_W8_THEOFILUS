using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace THA_W9_CONNECTSQL
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        string connectionString;
        string sqlQuery;
        DataTable dtteam = new DataTable();
        DataTable dtteam2 = new DataTable();
        DataTable dtplayer = new DataTable();
        DataTable dtpos = new DataTable();
        DataTable dtmatch = new DataTable();
        DataTable dtmatchdet = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnl.SendToBack();
            pnl.Visible = false;
            pnl.Enabled = false;
            connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=db_theo";
            conn = new MySqlConnection(connectionString);
            sqlQuery = "select t.team_name as 'Team Name', t.team_id as 'Team ID' from team t;";
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtteam);
            comboboxteam.DataSource = dtteam;
            comboboxteam.ValueMember = "Team ID";
            comboboxteam.DisplayMember = "Team Name";
        }

        private void comboboxplayer_SelectedValueChanged(object sender, EventArgs e)
        {
          

        }

        private void comboboxteam_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtplayer.Clear();
            sqlQuery = $"select p.player_name as 'Player Name', p.player_id as 'Player ID' from player p where p.team_id = '{comboboxteam.SelectedValue.ToString()}';";
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtplayer);
            comboboxplayer.DataSource = dtplayer;
            comboboxplayer.ValueMember = "Player ID";
            comboboxplayer.DisplayMember = "Player Name";
        }

        private void comboboxplayer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboboxplayer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            lbl6.Text = "";
            lbl7.Text = "";
            lbl8.Text = "";
            dtpos.Clear();
            string a = comboboxplayer.SelectedValue.ToString();
            sqlQuery = $"SELECT p.player_name as 'Name', t.team_name as 'Team Name' , p.playing_pos as 'Playing Pos' , n.nation as 'Nationality', ifnull(sum(dm.type='CY'),0) as 'Yellow Cards', ifnull(sum(dm.type='CY') , 0) as 'Red Cards',ifnull(sum(dm.type='CY') , 0) as 'Goal Scored', ifnull(sum(dm.type='CY') , 0 ) as 'Penalty Missed' FROM player p left JOIN team t on t.team_id = p.team_id left join dmatch dm on dm.player_id = p.player_id and dm.team_id = t.team_id inner join nationality n on n.nationality_id = p.nationality_id where p.player_id = '{a}' order by p.player_name asc;";
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtpos);
            lbl1.Text = "Player Name :" + dtpos.Rows[0][0];
            lbl2.Text = "Team Name :" + dtpos.Rows[0][1];
            lbl3.Text = "Playing Pos :" + dtpos.Rows[0][2];
            lbl4.Text = "Nationality :" + dtpos.Rows[0][3];
            if(dtpos.Rows[0][4] == null)
            {
                lbl5.Text = "Yellow Card :" + "-";
            }
            else
            {
                lbl5.Text = "Yellow Card :" + dtpos.Rows[0][4];
            }
            if (dtpos.Rows[0][5] == null)
            {
                lbl5.Text = "Red Card :" + "-";
            }
            else
            {
                lbl6.Text = "Red Card :" + dtpos.Rows[0][5];
            }
            if (dtpos.Rows[0][6] == null)
            {
                lbl5.Text = "Goal Scored :" + "-";
            }
            else
            {
                lbl7.Text = "Goal Scored :" + dtpos.Rows[0][6];
            }

            if (dtpos.Rows[0][7] == null)
            {
                lbl5.Text = "Penalty Missed :" + "-";
            }
            else
            {
                lbl8.Text = "Penalty Missed :" + dtpos.Rows[0][7];
            }
        }

        private void showMatchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl.BringToFront();
            pnl.Visible = true;
            pnl.Enabled = true;
            dtteam2.Clear();
            sqlQuery = "select t.team_name as 'Team Name', t.team_id as 'Team ID' from team t;";
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtteam2);
            comboboxteam2.DataSource = dtteam2;
            comboboxteam2.ValueMember = "Team ID";
            comboboxteam2.DisplayMember = "Team Name";
        }

        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl.SendToBack();
            pnl.Visible = false;
            pnl.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboboxteam2_SelectedValueChanged(object sender, EventArgs e)
        {
            dtmatch.Clear();
            sqlQuery = $"select m.match_id, m.team_home, m.team_away FROM db_theo.match m where m.team_home = '{comboboxteam2.SelectedValue.ToString()}' or m.team_away = '{comboboxteam2.SelectedValue.ToString()}';";
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtmatch);
            comboboxmatch.DataSource = dtmatch;
            comboboxmatch.ValueMember = "match_id";
            comboboxmatch.DisplayMember = "match_id";
        }

        private void comboboxmatch_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void comboboxmatch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtmatchdet.Clear();
            //sqlQuery = $"select * from dmatch where match_id = '{comboboxmatch.SelectedValue.ToString()}';";
            sqlQuery = $"select dm.minute, t.team_name, p.player_name, dm.type from dmatch dm, team t, player p where match_id = '{comboboxmatch.SelectedValue.ToString()}' and dm.team_id = t.team_id and dm.player_id = p.player_id;";
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtmatchdet);
            dgv.DataSource = dtmatchdet;
        }
    }
}
