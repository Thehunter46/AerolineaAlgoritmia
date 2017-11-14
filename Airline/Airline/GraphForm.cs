﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class GraphForm : Form
    {
        Graph graph;
        FlightsList flights;
        int create;
        int positionX, positionY;
        string citySelect;

        public GraphForm(int create, Graph graph, FlightsList flights)
        {
            this.create = create;
            this.graph = graph;
            this.flights = flights;
            positionX = positionY = 0;
            InitializeComponent();
            initializeGraph();
            if (create == 1)
                MessageBox.Show("Selecciona posicion de las nuevas ciudades", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            kruskal();
            
        }

        public void initializeGraph()
        {
            Pen pen1 = new Pen(Color.Red, 2);
            Font drawFont = new Font("Arial Rounded MT", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            foreach (Node n in graph.getNodeList())
            {
               
                panelMap.CreateGraphics().DrawEllipse(pen1, n.getCity().getX(), n.getCity().getY(), 20, 20);
                //panelMap.CreateGraphics().DrawEllipse(pen1, X, Y, 20, 20);
                //panelMap.CreateGraphics().DrawString(n.getCity().getName(),drawFont,drawBrush, n.getCity().getX() + 10, n.getCity().getY() + 10);
            }
            pen1.Color = Color.DarkSlateBlue;
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
            pen1.CustomEndCap = bigArrow;

            
            foreach (Node n in graph.getNodeList())
            {
                int i = 0;
                foreach (Adjacent adj in n.getAdjacentList())
                {
                    int X = n.getCity().getX() + 10;
                    int Y = n.getCity().getY() + 10;
                    int J = adj.getNode().getCity().getX() + 10;
                    int K = adj.getNode().getCity().getY() + 10;
                    panelMap.CreateGraphics().DrawLine(pen1, X, Y, J, K);
                    int halfX, halfY;
                    if (i % 2 == 0)
                    {
                        halfX = ((X + J) / 2) + 6;
                        halfY = ((Y + K) / 2) + 6;
                    }
                    else
                    {
                        halfX = ((X + J) / 2) - 6;
                        halfY = ((Y + K) / 2) - 6;
                    }
                    panelMap.CreateGraphics().DrawString(adj.getTime().ToString(), drawFont, drawBrush, halfX, halfY );
                    i++;
                }

            }

            foreach (Node n in graph.getNodeList())
            {
                panelMap.CreateGraphics().DrawString(n.getCity().getName(),drawFont,drawBrush, n.getCity().getX(), n.getCity().getY() - 15);
            }
        }

        private void panelMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (create == 1)
            {
                positionX = e.X - 10;
                positionY = e.Y - 10;
                MessageBox.Show("Punto almacenado", "Informacion ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            if (create == 2)
            {
                positionX = e.X - 10;
                positionY = e.Y - 10;
                labelCity.Text = citySelect = "";
                foreach(Node n in graph.getNodeList())
                {
                    if(n.getCity().getX() > positionX - 13 && n.getCity().getX() < positionX + 13)
                    {
                        if (n.getCity().getY() > positionY - 13 && n.getCity().getY() < positionY + 13)
                            citySelect = n.getCity().getName();
                    }
                }
                labelCity.Text = citySelect;
                
            }
        }

        public int getX()
        {
            return positionX;
        }

        private void GraphForm_Paint(object sender, PaintEventArgs e)
        {
            initializeGraph();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (citySelect != "")
            {
                graph.removeCity(citySelect);
                flights.removeFlights(citySelect);
                this.Refresh();
                labelCity.Text = "";
            }
            else
                MessageBox.Show("Selecciona una ciudad", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        public int getY()
        {
            return positionY;
        }

        public void kruskal()
        {
            List<string> componentes = new List<string>();
            ListaArista candidatos = new ListaArista();
            ListaArista arbolRM = new ListaArista();

            inicializaComponentes(componentes);
            inicializaCandidatos(candidatos,1);

            foreach(Arista candidato in candidatos)
            {
                if(seleccionKruskal(candidato,componentes))
                {
                    Console.WriteLine(candidato.getOrigin().getCity().getName() +
                        "->" + candidato.getDestinatin().getCity().getName() + " "
                        + candidato.getCost().ToString() + " SI");
                    arbolRM.Add(candidato);
                }
                else
                {
                    Console.WriteLine(candidato.getOrigin().getCity().getName() +
                        "->" + candidato.getDestinatin().getCity().getName() + " "
                        + candidato.getCost().ToString() + " NO");
                }
            }




        }

        public void inicializaComponentes(List<string> componentes)
        {
            foreach(Node node in graph.getNodeList())
            {
                componentes.Add(node.getCity().getName());
            }
        }

        public void inicializaCandidatos(ListaArista candidatos, int option)
        {
            Arista arista = new Arista();
            foreach (Node node in graph.getNodeList())
            {
                arista.setOrigin(node);
                foreach (Adjacent ady in node.getAdjacentList())
                {
                    arista.setDestination(ady.getNode());
                    if (option == 1)
                    {
                        arista.setCost(ady.getTime());
                    }
                    else if (option == 2)
                    {
                        arista.setCost(ady.getCost());
                    }
                    candidatos.Add(arista);
                }
            }
        }

        public bool seleccionKruskal(Arista candidato, List<string> componentes)
        {
            bool seleccion = false;
            
            
            return seleccion;
        }

        public void prim()
        {
            ListaArista candidatos = new ListaArista();
            ListaArista ARM = new ListaArista();
            inicializaCandidatos(candidatos, 1);
            candidatos.quickSort(0, candidatos.Count - 1);

            //for (int i = 0; i < candidatos.Count; i++) ;
            //{
            //    if()
            //}


        }

        

       
    }
}
