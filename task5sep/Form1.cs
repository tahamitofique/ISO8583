using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISO8583MsgParserGenerator
{
    public partial class Form1 : Form
    {
        static String msg,msg22,nmsg;
        static int j=0,BMT=0;  //55nimbus
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitbtn1_Click(object sender, EventArgs e)
        {

            msg22 = this.usernametext.Text;
            msg = parsedata(msg22);
            String l = this.headLengthtxt.Text;
            j = Int32.Parse(l);
            if (this.ComplexPBMbtn.Checked == true)
            {
                BMT = 1;
                nmsg=ComplexBM(msg22);
            }
            this.Hide();
            input(msg);
            //Form2 ss = new Form2();
            //ss.Show();
        }
        static string ComplexBM(string msgFl)
        {
            int t = 1, n = msgFl.LastIndexOf('|');
            String m = null,r=null;
            while (t <= msgFl.Length)
            {
                if (msgFl[t] == '|')
                {
                    t++;
                    while (true)
                    {
                        if (t >= n)
                        {
                            r = m.Substring(8, 34);
                            return (r);
                        };
                        if (msgFl[t] == '|')
                        {
                            break;
                        };
                        t++;
                    }

                }
                if (msgFl[t] == '|')
                {
                    while (true)
                    {
                        t = t + 2;
                        if (msgFl[t] == '|')
                            break;
                        m += msgFl[t];
                        t++;
                        m += msgFl[t];
                    }
                }
            }
            r = m.Substring(8, 34);
            return (r);
        }
        static string parsedata(string msgFl)
        {
            int t = 1, n = msgFl.LastIndexOf('|');
            String m = null;
            while (t <= msgFl.Length)
            {
                if (msgFl[t] == '|')
                {
                    while (true)
                    {
                        t = t + 2;
                        if (msgFl[t] == '|')
                            break;
                        m += msgFl[t];
                    }
                }
                if (msgFl[t] == '|')
                {
                    t++;
                    while (true)
                    {
                        if (t >= n)
                        {
                            return (m);
                        };
                        if (msgFl[t] == '|')
                        {
                            break;
                        };
                        t++;
                    }

                }
            }
            return (m);
        }
        static string Hexcon(string s)
        {
            string res1 = "";
            foreach (char ch in s)
            {
                switch (ch)
                {
                    case '0':
                        res1 += "0000";
                        break;
                    case '1':
                        res1 += "0001";
                        break;
                    case '2':
                        res1 += "0010";
                        break;
                    case '3':
                        res1 += "0011";
                        break;
                    case '4':
                        res1 += "0100";
                        break;
                    case '5':
                        res1 += "0101";
                        break;
                    case '6':
                        res1 += "0110";
                        break;
                    case '7':
                        res1 += "0111";
                        break;
                    case '8':
                        res1 += "1000";
                        break;
                    case '9':
                        res1 += "1001";
                        break;
                    case 'A':
                        res1 += "1010";
                        break;
                    case 'B':
                        res1 += "1011";
                        break;
                    case 'C':
                        res1 += "1100";
                        break;
                    case 'D':
                        res1 += "1101";
                        break;
                    case 'E':
                        res1 += "1110";
                        break;
                    case 'F':
                        res1 += "1111";
                        break;
                }

            }
            return (res1);

        }
        static void input(string code)
        {
            string header, mti, primary_bmap1, primary_bmap2, secondary_bmap1, secondary_bmap2;
            char[] charArr, charArr1=null;
            var Form2 = new Form2();
            header = code.Substring(0, j);//j=12   j+=0
            mti = code.Substring(j, 4);//j=12,4    j+=4
            j += 4;
            if (BMT==1)
            {
                primary_bmap1 = code.Substring(j, 8);
                j += 8;
                primary_bmap2 = Hexcon(nmsg.Substring(0,16));
                charArr = primary_bmap2.ToCharArray();
            }
            else
            {
                primary_bmap1 = code.Substring(j, 16); //j=16,16   j+=16
                j += 16;
                primary_bmap2 = Hexcon(primary_bmap1);
                charArr = primary_bmap2.ToCharArray();
            }
            string indexx = null;
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == '1')
                {
                    indexx += ((int)i + 1) + ",";
                }
            }
            if (charArr[0] == '1')
            {
                if (BMT == 1)
                {
                    secondary_bmap1 = code.Substring(j, 8);   //j=32
                    j += 8;
                    secondary_bmap2 = Hexcon(nmsg.Substring(16, 18));
                    charArr1 = secondary_bmap2.ToCharArray();
                }
                else
                {
                    secondary_bmap1 = code.Substring(j, 16);   //j=32
                    j += 16;
                    secondary_bmap2 = Hexcon(secondary_bmap1);
                    charArr1 = secondary_bmap2.ToCharArray();
                }
                for (int i = 0; i < charArr1.Length; i++)
                {
                    if (charArr1[i] == '1')
                    {
                        indexx += ((int)i + 65) + ",";
                    }


                }//j+=16     j=48
                Form2.Initial(header, mti, primary_bmap1, secondary_bmap1);
                parse(indexx, code);
                return;

            }
                Form2.Initial(header, mti, primary_bmap1);
                parse(indexx, code);

        }
        static void parse(string ind, string msg)
        {
            //int j = 0;
            //var Form2 = new Form2();
            string[] token = ind.Split(',');
            using (Form2 f2 = new Form2())
            {
                for (int i = 0; i < token.Length; i++)
             {


                switch (token[i])
                {
                    case "2":
                        string length = getdata(2);
                        int x = Int32.Parse(length);
                        string PAN = getdata(x);                             
                        f2.panG = PAN;
                        break;
                    case "3":
                        string Primarycode = getdata(6);
                        f2.pcG = Primarycode;
                        break;
                    case "4":
                        string amounttrans = getdata(12);
                        f2.atG = amounttrans;
                        break;
                    case "5":
                        string amountset = getdata(12);                
                        f2.asG = amountset;
                        break;
                    case "6":
                        string amountbill = getdata(12);
                        f2.acbG = amountbill;
                        break;
                    case "7":
                        string trandt = getdata(10);             
                        f2.tdtG = trandt;
                        break;
                    case "8":
                        string amountbillfee = getdata(8);
                        f2.acbfG = amountbillfee;
                        break;
                    case "9":
                        string convrtset = getdata(8);
                        f2.crsG = convrtset;
                        break;
                    case "10":
                        string convrtbill = getdata(8);
                        f2.crcbG = convrtbill;
                        break;
                    case "11":
                        string sysTrcAdt = getdata(6);
                        f2.stanG = sysTrcAdt;
                        break;
                    case "12":
                        string timeLclTran = getdata(6);
                        f2.tltG = timeLclTran;
                        break;
                    case "13":
                        string dateLclTran = getdata(4);
                        f2.dltG = dateLclTran;
                        break;
                    case "14":
                        string dateExp = getdata(4);
                        f2.dexpG = dateExp;
                        break;
                    case "15":
                        string dateSet = getdata(4);
                        f2.dsetG = dateSet;
                        break;
                    case "16":
                        string dateConv = getdata(4);
                        f2.dconG = dateConv;
                        break;
                    case "17":
                        string dateCapt = getdata(4);
                        f2.dcapG = dateCapt;
                        break;
                    case "18":
                        string merchantType = getdata(4);
                        f2.mtG = merchantType;
                        break;
                    case "19":
                        string AICC = getdata(3);
                        f2.aiccG = AICC;
                        break;
                    case "20":
                        string PANextCC = getdata(3);
                        f2.panccG = PANextCC;
                        break;
                    case "21":
                        string FICC = getdata(3);
                        f2.ficcG = FICC;
                        break;
                    case "22":
                        string POSem = getdata(3);
                        f2.psemG = POSem;
                        break;
                    case "23":
                        string CSN = getdata(3);
                        f2.csnG = CSN;
                        break;
                    case "24":
                        string NII = getdata(3);
                        f2.niiG = NII;
                        break;
                    case "25":
                        string POScc = getdata(2);
                        f2.posccG = POScc;
                        break;
                    case "26":
                        string POSpcc = getdata(2);
                        f2.pospccG = POSpcc;
                        break;
                    case "27":
                        string airl = getdata(1);
                        f2.airl1G = airl;
                        break;


                    case "32":
                        length = getdata(2);    
                        x = Int32.Parse(length);
                        string AIIC = getdata(x);
                        f2.aiicG = AIIC;
                        break;
                    case "33":
                        length = getdata(2);
                        x = Int32.Parse(length);
                        string FIIC = getdata(x);
                        f2.fiicG = FIIC;
                        break;
                    case "34":
                        length = getdata(2);
                        x = Int32.Parse(length);
                        string PANextd = getdata(x);
                        f2.paneG = PANextd;
                        break;
                    case "35":
                        length = getdata(2);
                        x = Int32.Parse(length);
                        string T2data = getdata(x);
                        f2.t2dG = T2data;
                        break;
                    case "36":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string T3data = getdata(x);
                        f2.t3dG = T3data;
                        break;
                    case "37":
                        string RRN = getdata(12);
                        f2.rrnG = RRN;
                        break;
                    case "38":
                        string authIR = getdata(6);
                        f2.airG = authIR;
                        break;
                    case "39":
                        string ResCode = getdata(2);
                        f2.rcG = ResCode;
                        break;
                    case "40":
                        string SRC = getdata(3);
                        f2.srcG = SRC;
                        break;
                    case "41":
                        string CATI = getdata(8);
                        f2.catiG = CATI;
                        break;
                    case "42":
                        string CAIC = getdata(15);
                        f2.caicG = CAIC;
                        break;
                    case "43":
                        string CANL = getdata(40);  //5nimbus
                        f2.canlG = CANL;
                        break;
                    case "44":
                        length = getdata(2);
                        x = Int32.Parse(length);
                        string ARdata = getdata(x);
                        f2.ardG = ARdata;
                        break;
                    case "45":
                        length = getdata(2);
                        x = Int32.Parse(length);
                        string T1data = getdata(x);
                        f2.t1dG = T1data;
                        break;
                    case "46":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string addISO = getdata(x);
                        f2.adISOG = addISO;
                        break;
                    case "47":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string addN = getdata(x);
                        f2.adNATIONALG = addN;
                        break;
                    case "48":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string addpvt = getdata(x);
                        f2.adPVTG = addpvt;
                        break;
                    case "49":
                        string CCtrans = getdata(3);
                        f2.cctG = CCtrans;
                        break;
                    case "50":
                        string CCset = getdata(3);
                        f2.ccsG = CCset;
                        break;
                    case "51":
                        string CCcb = getdata(3);
                        f2.cccbG = CCcb;
                        break;
                    case "52":
                        string PINdata = Hexcon(getdata(16));       //16nimbus
                        f2.PINdG = PINdata;
                        break;
                    case "53":
                        string SRCI = getdata(16);
                        f2.srciG = SRCI;
                        break;
                    case "54":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string addamt = getdata(x);
                        f2.aaG = addamt;
                        break;
                    case "55":
                        length = getdata(3);    
                        x = Int32.Parse(length);
                        string ICCsrd = getdata(x/4); //xnimbus
                        f2.ICCsrdG = ICCsrd;
                        break;
                    case "56":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvISO = getdata(x);
                        f2.rsvISOG = rsvISO;
                        break;
                    case "57":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvNAT1 = getdata(x);
                        f2.rsvNATIONAL1G = rsvNAT1;
                        break;
                    case "58":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvNAT2 = getdata(x);
                        f2.rsvNATIONAL2G = rsvNAT2;
                        break;
                    case "59":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvNAT3 = getdata(x);
                        f2.rsvNATIONAL3G = rsvNAT3;
                        break;
                    case "60":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string advRC = getdata(x);
                        f2.arcG = advRC;
                        break;
                    case "61":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string POSdata = getdata(x);
                        f2.POSdG = POSdata;
                        break;
                    case "62":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string INFdata = getdata(x);
                        f2.INFdG = INFdata;
                        break;
                    case "63":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string netData = getdata(x);
                        f2.ndG = netData;
                        break;
                    case "64":
                        string MAC = getdata(64);
                        f2.MACG = MAC;
                        break;
                    case "65":
                        string BMextd = getdata(64);
                        f2.bmextG = BMextd;
                        break;
                    case "66":
                        string setC = getdata(1);
                        f2.scG = setC;
                        break;
                    case "67":
                        string extdPC = getdata(2);
                        f2.epcG = extdPC;
                        break;
                    case "68":
                        string RICC = getdata(3);
                        f2.riccG = RICC;
                        break;
                    case "69":
                        string SICC = getdata(3);
                        f2.siccG = SICC;
                        break;
                    case "70":
                        string NMIC = getdata(3);
                        f2.nmicG = NMIC;
                        break;
                    case "71":
                        string msgno = getdata(4);
                        f2.mnG = msgno;
                        break;
                    case "72":
                        string msgnoL = getdata(4);
                        f2.mnlG = msgnoL;
                        break;
                    case "73":
                        string dateact = getdata(6);
                        f2.dateaG = dateact;
                        break;
                    case "74":
                        string crdtno = getdata(10);
                        f2.crdtnoG = crdtno;
                        break;
                    case "75":
                        string crdtrno = getdata(10);
                        f2.crdtrnoG = crdtrno;
                        break;
                    case "76":
                        string debtno = getdata(10);
                        f2.debtnoG = debtno;
                        break;
                    case "77":
                        string debtrno = getdata(10);
                        f2.debtrnoG = debtrno;
                        break;
                    case "78":
                        string tranno = getdata(10);
                        f2.tnoG = tranno;
                        break;
                    case "79":
                        string tranrno = getdata(10);
                        f2.trnoG = tranrno;
                        break;
                    case "80":
                        string inqno = getdata(10);
                        f2.inoG = inqno;
                        break;
                    case "81":
                        string authno = getdata(10);
                        f2.anoG = authno;
                        break;
                    case "82":
                        string crdtPfA = getdata(12);
                        f2.cpfaG = crdtPfA;
                        break;
                    case "83":
                        string crdtTfA = getdata(12);
                        f2.ctfaG = crdtTfA;
                        break;
                    case "84":
                        string debtPfA = getdata(12);
                        f2.dpfaG = debtPfA;
                        break;
                    case "85":
                        string debtTfA = getdata(12);
                        f2.dtfaG = debtTfA;
                        break;
                    case "86":
                        string crdtamt = getdata(16);
                        f2.crdtaG = crdtamt;
                        break;
                    case "87":
                        string crdtRamt = getdata(16);
                        f2.crdtraG = crdtRamt;
                        break;
                    case "88":
                        string debtamt = getdata(16);
                        f2.debtaG = debtamt;
                        break;
                    case "89":
                        string debtRamt = getdata(16);
                        f2.debtraG = debtRamt;
                        break;
                    case "90":
                        string Ode = getdata(42);
                        f2.odeG = Ode;
                        break;
                    case "91":
                        string fuc = getdata(1);
                        f2.fucG = fuc;
                        break;
                    case "92":
                        string fsc = getdata(2);
                        f2.fscG = fsc;
                        break;
                    case "93":
                        string ri = getdata(5);
                        f2.riG = ri;
                        break;
                    case "94":
                        string si = getdata(7);
                        f2.siG = si;
                        break;
                    case "95":
                        string ra = getdata(42);
                        f2.raG = ra;
                        break;
                    case "96":
                        string msgSecCode = getdata(64);
                        f2.mscG = msgSecCode;
                        break;
                    case "98":
                        string payee = getdata(25); 
                        f2.pG = payee;
                        break;
                    case "99":
                        length = getdata(2);
                        x = Int32.Parse(length);
                        string siic = getdata(x);
                        f2.siicG = siic;
                        break;
                    case "100":
                        length = getdata(2);
                        x = Int32.Parse(length);
                        string riic = getdata(x);
                        f2.riicG = riic;
                        break;
                    case "101":
                        length = getdata(2);
                        x = Int32.Parse(length);
                        string fn = getdata(x);
                        f2.fnG = fn;
                        break;
                    case "102":
                        length = getdata(2);
                        x = Int32.Parse(length);
                        string acciden1 = getdata(x);
                        f2.ai1G = acciden1;
                        break;
                    case "103":
                        length = getdata(2);
                        x = Int32.Parse(length);
                        string acciden2 = getdata(x);
                        f2.ai2G = acciden2;
                        break;
                    case "104":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string tranDesc = getdata(x);
                        f2.tdG = tranDesc;
                        break;
                    case "105":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvISO1 = getdata(x);
                        f2.rsviso1G = rsvISO1;
                        break;
                    case "106":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvISO2 = getdata(x);
                        f2.rsviso2G = rsvISO2;
                        break;
                    case "107":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvISO3 = getdata(x);
                        f2.rsviso3G = rsvISO3;
                        break;
                    case "108":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvISO4 = getdata(x);
                        f2.rsviso4G = rsvISO4;
                        break;
                    case "109":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvISO5 = getdata(x);
                        f2.rsviso5G = rsvISO5;
                        break;
                    case "110":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvISO6 = getdata(x);
                        f2.rsviso6G = rsvISO6;
                        break;
                    case "111":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvISO7 = getdata(x);
                        f2.rsviso7G = rsvISO7;
                        break;
                    case "112":
                        length = getdata(2);
                        x = Int32.Parse(length);
                        string parc = getdata(x);
                        f2.pG = parc;
                        break;
                    case "113":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvNat1 = getdata(x);
                        f2.rsvN1G = rsvNat1;
                        break;
                    case "114":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvNat2 = getdata(x);
                        f2.rsvN2G = rsvNat2;
                        break;
                    case "115":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvNat3 = getdata(x);
                        f2.rsvN3G = rsvNat3;
                        break;
                    case "116":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvNat4 = getdata(x);
                        f2.rsvN4G = rsvNat4;
                        break;
                    case "117":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvNat5 = getdata(x);
                        f2.rsvN5G = rsvNat5;
                        break;
                    case "118":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvNat6 = getdata(x);
                        f2.rsvN6G = rsvNat6;
                        break;
                    case "119":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvNat7 = getdata(x);
                        f2.rsvN7G = rsvNat7;
                        break;
                    case "120":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rcddata = getdata(x);
                        f2.rdG = rcddata;
                        break;
                    case "121":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string aaic = getdata(x);
                        f2.aaicG = aaic;
                        break;
                    case "122":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvFmc1 = getdata(x);
                        f2.rsvfutr1G = rsvFmc1;
                        break;
                    case "123":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvFmc2 = getdata(x);
                        f2.rsvfutr2G = rsvFmc2;
                        break;
                    case "124":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvFmc3 = getdata(x);
                        f2.rsvfutr3G = rsvFmc3;
                        break;
                    case "125":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvFmc4 = getdata(x);
                        f2.rsvfutr4G = rsvFmc4;
                        break;
                    case "126":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string rsvPVT = getdata(x);
                        f2.rsvpvtG = rsvPVT;
                        break;
                    case "127":
                        length = getdata(3);
                        x = Int32.Parse(length);
                        string pvtData = getdata(x);
                        f2.pvtdataG = pvtData;
                        break;
                    case "128":
                        string MAC2 = getdata(16);
                        f2.MAC2G = MAC2;
                        break;
                    default:
                        break;

                }
            }
                f2.ShowDialog();
            }
        }
        static public String getdata(int len)
        {
            String dat=null;
            dat = msg.Substring(j, len);
            j += len;
            return (dat);
        }
        


        private void usernametext_TextChanged(object sender, EventArgs e)
        {
        }

        private void SimplePBMbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ComplexPBMbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
