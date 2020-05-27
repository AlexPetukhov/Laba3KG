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
    public OpenTK.Vector3 boxMaterial;
    
        public OpenTK.Vector3 lightPostion;
        public OpenTK.Vector3 lightReflection;
        public OpenTK.Vector3 lightRefraction;
        public OpenTK.Vector3 boxPosition;
    public const int DIFFUSE_REFLECTION = 1;
    public const int MIRROR_REFLECTION = 2;
    public const int REFRACTION = 3;

    public const int countMaterials = 9;
    public Material[] materials = new Material[countMaterials];
        public OpenTK.Vector3 boxColor;
    
        public Shader(int width, int height)
        {
            lightPostion = new OpenTK.Vector3(2.0f, 4.0f, -4.0f);
            boxPosition = new OpenTK.Vector3(-0.2f, -2.2f, 1.8f);
            lightReflection = new OpenTK.Vector3(0.5f);
            lightRefraction = new OpenTK.Vector3(20.0f);
            boxSize = new OpenTK.Vector3(0.5f);
        boxColor = new OpenTK.Vector3(4.0f);
        boxMaterial = new OpenTK.Vector3(1);
        

            GL.ShadeModel(ShadingModel.Smooth);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
        
            Resize(width, height);
        fillMaterials();

        id = GL.CreateProgram();

            InitShader(width, height);
        }

        public struct Material
        {
            public OpenTK.Vector3 Color;
            public OpenTK.Vector4 LightCoeffs;
            public float ReflectionCoef;
            public float RefractionCoef;
            public int MaterilaType;
            public Material(OpenTK.Vector3 col, OpenTK.Vector4 Light, float reflection, float refraction, int type)
            {
                Color = col;
                LightCoeffs = Light;
                ReflectionCoef = reflection;
                RefractionCoef = refraction;
                MaterilaType = type;
            }
        }
    public void setMaterial(int i, Material material)
    {
        materials[i] = material;
    }

    private void fillMaterials()
    {
        OpenTK.Vector4 lightCoeffs = new OpenTK.Vector4(0.4f, 0.9f, 0.2f, 2.0f);
        materials[0] = new Material(new OpenTK.Vector3(0, 1, 0), lightCoeffs, 0.5f, 1, DIFFUSE_REFLECTION);
        materials[1] = new Material(new OpenTK.Vector3(1, 0, 0), lightCoeffs, 0.5f, 1, DIFFUSE_REFLECTION);
        materials[2] = new Material(new OpenTK.Vector3(0, 0, 1), lightCoeffs, 0.5f, 1, DIFFUSE_REFLECTION);
        materials[3] = new Material(new OpenTK.Vector3(1, 1, 0), lightCoeffs, 0.5f, 1, MIRROR_REFLECTION);
        materials[4] = new Material(new OpenTK.Vector3(0, 1, 1), lightCoeffs, 0.5f, 1, DIFFUSE_REFLECTION);
        materials[5] = new Material(new OpenTK.Vector3(1, 0, 1), lightCoeffs, 1, 1, MIRROR_REFLECTION);
        materials[6] = new Material(new OpenTK.Vector3(0.5f, 0.5f, 1), lightCoeffs, 1, 1.5f, REFRACTION);
        materials[7] = new Material(new OpenTK.Vector3(0.5f, 0.5f, 0.5f), lightCoeffs, 1, 1.5f, DIFFUSE_REFLECTION);
        materials[8] = new Material(new OpenTK.Vector3(0.5f, 0.5f, 1), lightCoeffs, 1, 1.5f, DIFFUSE_REFLECTION);
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
            GL.Uniform3(GL.GetUniformLocation(id, "BOX_MATERIAL"), boxMaterial);

        GL.Begin(PrimitiveType.Quads);

            GL.Vertex2(-width, -height);
            GL.Vertex2(width, -height);
            GL.Vertex2(width, height);
            GL.Vertex2(-width, height);

            GL.End();
        }
}
