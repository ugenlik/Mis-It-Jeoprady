using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mis_It_Jeoprady
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player;
        bool isPlaying = false;

        public Form1()
        {
            InitializeComponent();
            button26_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new chap4_200("What is Spyware?", "A software \nthat surreptitiously installed on user’s computer\n may transmit user’s keystrokes or display unwanted ads").Visible = true;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new chap4_200("What is Cookies?", "Tiny files downloaded by Web site to visitor’s hard drive\n to identify visitor’s browser and track visits to site and \nallow Web sites to develop profiles on visitors").Visible = true;
            button2.Visible = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                player.Stop();
                isPlaying = false;
            }
            else
            {
                player = new System.Media.SoundPlayer("right.wav");
                player.PlayLooping();
                isPlaying = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new chap4_200("What is Descartes' rule of change?", "If an action cannot be taken repeatedly,\n it is not right to take at all").Visible = true;
            button3.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new chap4_200("What are the majorr issues raised by information systems include?", "Information rights and obligations\nProperty rights and obligations\nAccountability and control\nSystem quality\nQuality of life").Visible = true;
            button4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new chap4_200("What is data analysis advances?", "Greater ability to find detailed personal information on individuals\nProfiling and nonobvious relationship awareness (NORA)").Visible = true;
            button5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new chap4_200(" These lightweight subnotebooks are optimized for wireless communication", "Netbooks").Visible = true;
            button6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new chap4_200("What does Moore’s law state?", "Computing power doubles every 18 months").Visible = true;
            button7.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new chap4_200("What are small software programs that can be added to web pages\n or placed on the desktop to provide additional functionality?", "Widgets").Visible = true;
            button8.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new chap4_200("Which model can be used to analyze direct and indirect costs to help firms \ndetermine the actual costs of specific technology?", "Total Cost of Ownership").Visible = true;
            button9.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new chap4_200("In the case we examined in class,\n cars.com enlisted the help of standardized IBM platforms and this to allow \nthe company to build new applications and services more rapidly\n by using plug-and-play technologies?", "Service Oriented Architecture").Visible = true;
            button10.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new chap4_200("What is a database?", "Is a collection of data organized to serve many applications\nefficiently by centralizing the data and controlling redundant data.").Visible = true;
            button11.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new chap4_200("What is SQL( Strauctured Query Language),?", " Is a popluar form of data manipulation Language\n for database management systems.").Visible = true;
            button12.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new chap4_200("What is online analytical processing(OLAP)?", "Supports multidimensional data anaylsis, \nenabling users to view the data in different ways using multiple dimensions.").Visible = true;
            button13.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            new chap4_200("What is a data warehouse or compliance data warehouse(CDW)?", "In this case study the IRS used what to uncover tax fraud with this new MIS system").Visible = true;
            button14.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            new chap4_200("What is select suppliers for parts 18 or 100, (parts 18 or parts 100)?", " SELECT PART.Part_Number, PART.Part_Name, SUPPLIER.\nSupplier_Number, SUPPLIER. Supplier_Name\n\nFrom PART, SUPPLIER\n\nWhere PART. Supplier_Number= SUPPLIER.\nSupplier_Number and Part_Number = 18 or Part_Number =100").Visible = true;
            button15.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            new chap4_200("What is a “MAN”?", "Is a network that spans a city, \nand sometimes its major suburbs as well.").Visible = true;
            button16.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            new chap4_200("What is a “VPN”?", "Is an encrypted private network configured within a public network.").Visible = true;
            button17.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            new chap4_200("What is “packet switching”?", "is a method of slicing digital messages into parcels (packets), \nsending packets along different communication paths as they become available,\n and then reassembling packets at destination.").Visible = true;
            button18.Visible = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            new chap4_200("What is “Web 2.0”?", "Is a second-generation interactive \nInternet-based service enabling people to collaborate,\n share information, and create new services online. ").Visible = true;
            button19.Visible = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            new chap4_200("What is the “Department of Defense reference model for TCP/IP”?", "Application layer\nTransport layer\nInternet layer\nNetwork interface layer\n").Visible = true;
            button20.Visible = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            new chap4_200("What is Cybervandalism?", "Intentional disruption, defacement,\n or destruction of a web site or \ncorporate information system").Visible = true;
            button21.Visible = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            new chap4_200("What is Denial-of-Service attack?", " Hackers flood a network server or web server\n with many thousands of false communications\n or requests for services to crash the network").Visible = true;
            button22.Visible = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            new chap4_200("What can lack of security and/or control lead to?", "Loss of revenue\nLowered market value\nLegal liability\nLower employee productivity\nHigher operational costs").Visible = true;
            button23.Visible = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            new chap4_200("What are information systems vulnerable?", "Hardware problem\nSoftware problem\nDisaster\nUse of networks and computers outside of firm’s control").Visible = true;
            button24.Visible = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            new chap4_200("Define fault-tolerant computer systems and high-availability computing.\n What are the similarities and difference between the two?", "Fault-tolerant computer systems contain redundant hardware, software, \nand power supply components that create an environment that provides continuous,\n uninterrupted service.\n\nHigh-availability computing helps firms recover quickly from a system crash.\nSimilarity: both try to minimize downtime\nFault;tolerant computer system ensures continous availability\nwhile high availability computing cannot ").Visible = true;
            button25.Visible = false;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            button24.Visible = true;
            button25.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
