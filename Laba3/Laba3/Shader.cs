using System;
using System.IO;
using OpenTK.Graphics.OpenGL;
using System.Windows.Forms;

class Shader
    {
        private int width;
        private int height;
        private int id;
        public OpenTK.Vector3 boxSize;
        public OpenTK.Vector3 lightPostion;
        public OpenTK.Vector3 lightReflection;
        public OpenTK.Vector3 lightRefraction;
        public OpenTK.Vector3 boxPosition;
        public OpenTK.Vector3 boxColor;
    
        public Shader(int width, int height)
        {
            lightPostion = new OpenTK.Vector3(2.0f, 4.0f, -4.0f);
            boxPosition = new OpenTK.Vector3(-0.2f, -2.2f, 1.8f);
            lightReflection = new OpenTK.Vector3(0.5f);
            lightRefraction = new OpenTK.Vector3(20.0f);
            boxSize = new OpenTK.Vector3(0.5f);
            boxColor = new OpenTK.Vector3(4.0f);

            GL.ShadeModel(ShadingModel.Smooth);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            Resize(width, height);

            id = GL.CreateProgram();

            InitShader(width, height);
        }
    
        private void InitShader(int width, int height)
        {
            string repositoryPath = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @"..\..\"));

            int vertexShader;
            int fragmentShader;
            string vertPath = repositoryPath + "raytracing.vert";
            string fragPath = repositoryPath + "raytracing.frag";
        
            LoadShader(vertPath, id, out vertexShader);
            LoadShader(fragPath, id, out fragmentShader);
        
            GL.LinkProgram(id);

            int status;
            GL.GetProgram(id, GetProgramParameterName.LinkStatus, out status);
            Console.WriteLine(GL.GetProgramInfoLog(id));
        }

        public void SetBoxSize(double value)
        {
            boxSize = new OpenTK.Vector3((float)value);
        }
    
        public void Resize(int width, int height)
        {
            this.width = width;
            this.height = height;

            GL.Ortho(0, width, 0, height, -1, 1);
            GL.Viewport(0, 0, width, height);
        }

        public void LoadShader(string filename, int program, out int address)
        {
            switch (Path.GetExtension(filename))
            {
                case ".vert":
                    address = GL.CreateShader(ShaderType.VertexShader);
                    break;

                case ".frag":
                    address = GL.CreateShader(ShaderType.FragmentShader);
                    break;

                default:
                    address = 0;
                    break;
            }

            StreamReader reader = new StreamReader(filename);

            GL.ShaderSource(address, reader.ReadToEnd());

            GL.CompileShader(address);
            GL.AttachShader(program, address);

            Console.WriteLine(GL.GetShaderInfoLog(address));

            reader.Close();
        }

        public void DrawQuads()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.UseProgram(id);

            GL.Uniform3(GL.GetUniformLocation(id, "LIGHT_POSITION"), lightPostion);
            GL.Uniform3(GL.GetUniformLocation(id, "LIGHT_REFLECTION"), lightReflection);
            GL.Uniform3(GL.GetUniformLocation(id, "LIGHT_REFRACTION"), lightRefraction);
            GL.Uniform3(GL.GetUniformLocation(id, "BOX_CENTER"), boxPosition);
            GL.Uniform3(GL.GetUniformLocation(id, "BOX_SIZE"), boxSize);
            GL.Uniform3(GL.GetUniformLocation(id, "BOX_COLOR"), boxColor);

            GL.Begin(PrimitiveType.Quads);

            GL.Vertex2(-width, -height);
            GL.Vertex2(width, -height);
            GL.Vertex2(width, height);
            GL.Vertex2(-width, height);

            GL.End();
        }
}
