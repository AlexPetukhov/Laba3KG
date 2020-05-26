using OpenTK;
using OpenTK.Graphics;
using System;
using System.Threading;
using System.Windows.Forms;


namespace Laba3
{
    public partial class Form1 : Form
    {
        private GLControl panel;
        private Shader shader;
        private Thread updateThread;
        public Form1()
        {
            InitializeComponent();

            panel = new OpenTK.GLControl(new OpenTK.Graphics.GraphicsMode(ColorFormat.Empty, 24, 0, 8));
            panel.Paint += GLPaint;

            SuspendLayout();

            panel.Location = new System.Drawing.Point(0, 0);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(Width / 2, Height);
            panel.TabIndex = 0;

            Controls.Add(panel);
            ResumeLayout(false);

            xBar.Minimum = -3;
            xBar.Maximum = 3;
            yBar.Minimum = -3;
            yBar.Maximum = 3;
            zBar.Minimum = -3;
            zBar.Maximum = 3;
            colorBar.Maximum = 4;
            refractionBar.Minimum = 2;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panel.MakeCurrent();

            shader = new Shader(panel.Width, panel.Height);

            updateThread = new Thread(Update);
            updateThread.Start();

            int N = shader.materials.Length;
            for (int i = 0; i < N; i++)
            {
                listBox1.Items.Add(i);
            }
            listBox1.SelectedIndex = 0;

            this.Closed += CloseEvent;
        }

        private void GLPaint(object sender, PaintEventArgs e)
        {
            panel.MakeCurrent();
            shader.DrawQuads();
            panel.SwapBuffers();
        }
        
        private void Form1_Resize(object sender, EventArgs e)
        {
            panel.Width = Width / 2;
            panel.Height = Height;

            if (Created)
                shader.Resize(panel.Width, panel.Height);
        }
        
        private new void Update()
        {
            bool dirX = true;
            bool dirZ = true;
            float step = 0.00001f;

            while (true)
            {
                if (dirX)
                {
                    while (shader.lightPostion.X < 4)
                    {
                        shader.lightPostion.X += step;
                        panel.Invalidate();
                    }
                }
                else
                {
                    while (shader.lightPostion.X > -4)
                    {
                        shader.lightPostion.X -= step;
                        panel.Invalidate();
                    }
                }

                if (dirZ)
                {
                    while (shader.lightPostion.Z < 3)
                    {
                        shader.lightPostion.Z += step;
                        panel.Invalidate();
                    }
                }else
                {
                    while (shader.lightPostion.Z > -3)
                    {
                        shader.lightPostion.Z -= step;
                        panel.Invalidate();
                    }
                }
                dirX = !dirX;
                dirZ = !dirZ;
            }
        }
        
        public void CloseEvent(object sender, System.EventArgs e)
        {
            updateThread.Abort();
        }
        
        private void boxSizeBar_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            shader.SetBoxSize(trackBar.Value);
        }

        private void boxXBar_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            shader.boxPosition.X = trackBar.Value;
        }

        private void boxYBar_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            shader.boxPosition.Y = trackBar.Value;
        }

        private void boxZBar_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            shader.boxPosition.Z = trackBar.Value;
        }

        private void boxColorBar_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            shader.boxColor = new Vector3(trackBar.Value);
        }

        private void reflectionBar_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            shader.lightReflection = new Vector3((float)trackBar.Value / (float)trackBar.Maximum);
        }

        private void refractionBar_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            shader.lightRefraction = new Vector3((float)trackBar.Value / (float)trackBar.Maximum);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Shader.Material material = shader.materials[(int)listBox1.SelectedItem];
            //materialColor.Text = material.Color.X + " " + material.Color.Y + " " + material.Color.Z;
            //LightCoeffs.Text = material.LightCoeffs.X + " " + material.LightCoeffs.Y + " " + material.LightCoeffs.Z + " " + material.LightCoeffs.W;
            //ReflectionCoef.Text = Convert.ToString(material.ReflectionCoef);
            //RefractionCoef.Text = Convert.ToString(material.RefractionCoef);
            //MaterialType.Text = Convert.ToString(material.MaterilaType);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //float[] tmp = materialColor.Text.Trim().Split().Select((s) => Convert.ToSingle(s)).ToArray();
           // float[] tmp2 = LightCoeffs.Text.Trim().Split().Select((s) => Convert.ToSingle(s)).ToArray();
            //S/hader.Material material = new Shader.Material(
                //new OpenTK.Vector3(tmp[0], tmp[1], tmp[2]),
             //   new OpenTK.Vector4(tmp2[0], tmp2[1], tmp2[2], tmp2[3]),
                //Convert.ToSingle(ReflectionCoef.Text.Trim()),
               // Convert.ToSingle(RefractionCoef.Text.Trim()),
               // Convert.ToInt32(MaterialType.Text.Trim())
            //);
            //shader.setMaterial((int)listBox1.SelectedItem, material);
        }
    }
}

