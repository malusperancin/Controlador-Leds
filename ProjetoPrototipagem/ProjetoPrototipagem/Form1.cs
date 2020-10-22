using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ProjetoPrototipagem
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            timerCOM.Enabled = true;
        }

       void Terminou(object sender, EventArgs e)
        {
            btnEfeito2.Enabled = true; //habilita os botoes novamente
            btnEfeito3.Enabled = true;
            btnEfeito4.Enabled = true;
            btnEfeito1.Enabled = true;
            btnEfeito5.Enabled = true;
            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = false;
            pb4.Visible = false;
            pb5.Visible = false;

        }
            
        
        private void spSerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
         
           string stop = spSerial.ReadExisting();
          

            if ( stop == "s")  //se for s, é pq acabou o efeito
                this.Invoke(new EventHandler(Terminou));
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {


            if (!spSerial.IsOpen) // Porta fechada
            {
                try
                {
                    spSerial.PortName = cbxPortas.Text;
                    spSerial.Open();

                }
                catch
                {
                    return;
                }
                if (spSerial.IsOpen) // abriu!!
                {
                    btnLigar.Text = "Desconectar";
                    cbxPortas.Enabled = false;
                    btnEfeito1.Enabled = true;
                    btnEfeito2.Enabled = true;
                    btnEfeito3.Enabled = true;
                    btnEfeito4.Enabled = true;
                    btnEfeito5.Enabled = true;
                }
            }
            else
            {
                try
                {
                    spSerial.Close();
                    cbxPortas.Enabled = true;
                    btnLigar.Text = "Conectar";
                    btnEfeito1.Enabled = false;
                    btnEfeito2.Enabled = false;
                    btnEfeito3.Enabled = false;
                    btnEfeito4.Enabled = false;
                    btnEfeito5.Enabled = false;

                }
                catch
                {
                    return;
                }
            }



        }

        private void btnEfeito1_Click(object sender, EventArgs e)
        {

            pb1.Visible = true;
            btnEfeito2.Enabled = false;
            btnEfeito3.Enabled = false;
            btnEfeito4.Enabled = false;
            btnEfeito5.Enabled = false;


            if (spSerial.IsOpen) //porta está aberta
                spSerial.Write("q"); //envia o texto digitado


        }

        private void btnEfeito2_Click(object sender, EventArgs e)
        {
            btnEfeito1.Enabled = false; //desabilita os botoes que nao foram acertados
            btnEfeito3.Enabled = false;
            btnEfeito4.Enabled = false;
            btnEfeito5.Enabled = false;
            pb2.Visible = true;
            if (spSerial.IsOpen) //porta está aberta
                spSerial.Write("w"); //envia o texto digitado
        }

        private void btnEfeito3_Click(object sender, EventArgs e)
        {
            btnEfeito2.Enabled = false;
            btnEfeito1.Enabled = false;
            btnEfeito4.Enabled = false;
            btnEfeito5.Enabled = false;
            pb3.Visible = true;
            if (spSerial.IsOpen) //porta está aberta
                spSerial.Write("e"); //envia o texto digitado
        }

        private void btnEfeito4_Click(object sender, EventArgs e)
        {
            btnEfeito2.Enabled = false;
            btnEfeito3.Enabled = false;
            btnEfeito1.Enabled = false;
            pb4.Visible = true;
            btnEfeito5.Enabled = false;
            if (spSerial.IsOpen) //porta está aberta
                spSerial.Write("r"); //envia o texto digitado
        }

        private void btnEfeito5_Click(object sender, EventArgs e)
        {
            btnEfeito2.Enabled = false;
            btnEfeito3.Enabled = false;
            btnEfeito4.Enabled = false;
            btnEfeito1.Enabled = false;
            pb5.Visible = true;
            if (spSerial.IsOpen) //porta está aberta
                spSerial.Write("t"); //envia o texto digitado
        }


        private void atualizaListaCOMs()
        {
            int i = 0;
            bool quantDiferente; //flag para sinalizar se
                                 //a quantidade de portas mudou
            quantDiferente = false;
            //se a quantidade de portas mudou
            if (cbxPortas.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (!cbxPortas.Items[i++].Equals(s))
                    {
                        quantDiferente = true;
                        break; // escapa do foreach
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }
            //Se não foi detectado diferença
            if (!quantDiferente)
            {
                return; //retorna
            }
            //limpa comboBox
            cbxPortas.Items.Clear();
            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                cbxPortas.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            cbxPortas.SelectedIndex = 0;
        }

        private void timerCOM_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }
      
        private void frmArduino_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (spSerial.IsOpen) // se porta aberta
                spSerial.Close(); //fecha a port
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEfeito1.Enabled = false; // para o usuario nao apertar o botao antes de definir a com
            btnEfeito2.Enabled = false;
            btnEfeito3.Enabled = false;
            btnEfeito4.Enabled = false;
            btnEfeito5.Enabled = false;
        }
    }
}

