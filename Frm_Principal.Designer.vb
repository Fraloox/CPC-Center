<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Principal
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim Animation2 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal))
		Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
		Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
		Me.pnl_Mover = New Guna.UI2.WinForms.Guna2Panel()
		Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
		Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
		Me.trs_Aparecer = New Guna.UI2.WinForms.Guna2Transition()
		Me.pnl_Principal = New Guna.UI2.WinForms.Guna2Panel()
		Me.pnl_Contenido = New Guna.UI2.WinForms.Guna2Panel()
		Me.pnl_Menu = New Guna.UI2.WinForms.Guna2Panel()
		Me.btn_Ajustes = New Guna.UI2.WinForms.Guna2Button()
		Me.btn_CerrarS = New Guna.UI2.WinForms.Guna2Button()
		Me.btn_Ventas = New Guna.UI2.WinForms.Guna2Button()
		Me.Personas = New Guna.UI2.WinForms.Guna2Button()
		Me.btn_Articulos = New Guna.UI2.WinForms.Guna2Button()
		Me.btn_Equipos = New Guna.UI2.WinForms.Guna2Button()
		Me.btn_Home = New Guna.UI2.WinForms.Guna2Button()
		Me.pnl_Filtros = New Guna.UI2.WinForms.Guna2Panel()
		Me.lb_Quitar = New System.Windows.Forms.Label()
		Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lb_Minimizar = New System.Windows.Forms.Label()
		Me.pnl_Login = New Guna.UI2.WinForms.Guna2Panel()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txt_ConfirmPass = New Guna.UI2.WinForms.Guna2TextBox()
		Me.txt_Pass = New Guna.UI2.WinForms.Guna2TextBox()
		Me.txt_DNI = New Guna.UI2.WinForms.Guna2TextBox()
		Me.btn_IniciarS = New Guna.UI2.WinForms.Guna2Button()
		Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
		Me.lb_Bienvenida = New System.Windows.Forms.Label()
		Me.pic_Cargando = New Guna.UI2.WinForms.Guna2CircleProgressBar()
		Me.tmr_Iniciar = New System.Windows.Forms.Timer(Me.components)
		Me.pnl_Contenedor = New System.Windows.Forms.Panel()
		Me.pnl_Principal.SuspendLayout()
		Me.pnl_Contenido.SuspendLayout()
		Me.pnl_Menu.SuspendLayout()
		CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnl_Login.SuspendLayout()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Guna2AnimateWindow1
		'
		Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND
		'
		'Guna2Elipse1
		'
		Me.Guna2Elipse1.TargetControl = Me
		'
		'pnl_Mover
		'
		Me.trs_Aparecer.SetDecoration(Me.pnl_Mover, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.pnl_Mover.Location = New System.Drawing.Point(161, 0)
		Me.pnl_Mover.Name = "pnl_Mover"
		Me.pnl_Mover.ShadowDecoration.Parent = Me.pnl_Mover
		Me.pnl_Mover.Size = New System.Drawing.Size(845, 52)
		Me.pnl_Mover.TabIndex = 0
		'
		'Guna2DragControl1
		'
		Me.Guna2DragControl1.TargetControl = Me.pnl_Mover
		'
		'trs_Aparecer
		'
		Me.trs_Aparecer.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
		Me.trs_Aparecer.Cursor = Nothing
		Animation2.AnimateOnlyDifferences = True
		Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
		Animation2.LeafCoeff = 0!
		Animation2.MaxTime = 1.0!
		Animation2.MinTime = 0!
		Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
		Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
		Animation2.MosaicSize = 0
		Animation2.Padding = New System.Windows.Forms.Padding(0)
		Animation2.RotateCoeff = 0!
		Animation2.RotateLimit = 0!
		Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
		Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
		Animation2.TimeCoeff = 0!
		Animation2.TransparencyCoeff = 1.0!
		Me.trs_Aparecer.DefaultAnimation = Animation2
		Me.trs_Aparecer.Interval = 100
		'
		'pnl_Principal
		'
		Me.pnl_Principal.Controls.Add(Me.pnl_Contenedor)
		Me.pnl_Principal.Controls.Add(Me.pnl_Contenido)
		Me.pnl_Principal.Controls.Add(Me.pnl_Menu)
		Me.trs_Aparecer.SetDecoration(Me.pnl_Principal, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.pnl_Principal.Location = New System.Drawing.Point(2, 51)
		Me.pnl_Principal.Name = "pnl_Principal"
		Me.pnl_Principal.ShadowDecoration.Parent = Me.pnl_Principal
		Me.pnl_Principal.Size = New System.Drawing.Size(1085, 611)
		Me.pnl_Principal.TabIndex = 1
		Me.pnl_Principal.Visible = False
		'
		'pnl_Contenido
		'
		Me.pnl_Contenido.BackColor = System.Drawing.Color.Transparent
		Me.pnl_Contenido.BorderColor = System.Drawing.Color.Black
		Me.pnl_Contenido.BorderRadius = 15
		Me.pnl_Contenido.BorderThickness = 1
		Me.pnl_Contenido.Controls.Add(Me.pic_Cargando)
		Me.trs_Aparecer.SetDecoration(Me.pnl_Contenido, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.pnl_Contenido.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
		Me.pnl_Contenido.Location = New System.Drawing.Point(249, 0)
		Me.pnl_Contenido.Name = "pnl_Contenido"
		Me.pnl_Contenido.ShadowDecoration.Parent = Me.pnl_Contenido
		Me.pnl_Contenido.Size = New System.Drawing.Size(848, 628)
		Me.pnl_Contenido.TabIndex = 3
		'
		'pnl_Menu
		'
		Me.pnl_Menu.Controls.Add(Me.btn_Ajustes)
		Me.pnl_Menu.Controls.Add(Me.btn_CerrarS)
		Me.pnl_Menu.Controls.Add(Me.btn_Ventas)
		Me.pnl_Menu.Controls.Add(Me.Personas)
		Me.pnl_Menu.Controls.Add(Me.btn_Articulos)
		Me.pnl_Menu.Controls.Add(Me.btn_Equipos)
		Me.pnl_Menu.Controls.Add(Me.btn_Home)
		Me.trs_Aparecer.SetDecoration(Me.pnl_Menu, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left
		Me.pnl_Menu.Enabled = False
		Me.pnl_Menu.Location = New System.Drawing.Point(0, 0)
		Me.pnl_Menu.Name = "pnl_Menu"
		Me.pnl_Menu.ShadowDecoration.Parent = Me.pnl_Menu
		Me.pnl_Menu.Size = New System.Drawing.Size(251, 611)
		Me.pnl_Menu.TabIndex = 2
		'
		'btn_Ajustes
		'
		Me.btn_Ajustes.BackColor = System.Drawing.Color.Transparent
		Me.btn_Ajustes.BorderRadius = 5
		Me.btn_Ajustes.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(158, Byte), Integer))
		Me.btn_Ajustes.CheckedState.Parent = Me.btn_Ajustes
		Me.btn_Ajustes.CustomImages.Parent = Me.btn_Ajustes
		Me.trs_Aparecer.SetDecoration(Me.btn_Ajustes, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.btn_Ajustes.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
		Me.btn_Ajustes.Font = New System.Drawing.Font("Segoe UI", 11.0!)
		Me.btn_Ajustes.ForeColor = System.Drawing.Color.White
		Me.btn_Ajustes.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(232, Byte), Integer))
		Me.btn_Ajustes.HoverState.Parent = Me.btn_Ajustes
		Me.btn_Ajustes.Location = New System.Drawing.Point(3, 502)
		Me.btn_Ajustes.Name = "btn_Ajustes"
		Me.btn_Ajustes.ShadowDecoration.Parent = Me.btn_Ajustes
		Me.btn_Ajustes.Size = New System.Drawing.Size(245, 49)
		Me.btn_Ajustes.TabIndex = 6
		Me.btn_Ajustes.Text = "Ajustes"
		'
		'btn_CerrarS
		'
		Me.btn_CerrarS.BackColor = System.Drawing.Color.Transparent
		Me.btn_CerrarS.BorderRadius = 5
		Me.btn_CerrarS.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(158, Byte), Integer))
		Me.btn_CerrarS.CheckedState.Parent = Me.btn_CerrarS
		Me.btn_CerrarS.CustomImages.Parent = Me.btn_CerrarS
		Me.trs_Aparecer.SetDecoration(Me.btn_CerrarS, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.btn_CerrarS.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
		Me.btn_CerrarS.Font = New System.Drawing.Font("Segoe UI", 11.0!)
		Me.btn_CerrarS.ForeColor = System.Drawing.Color.White
		Me.btn_CerrarS.HoverState.FillColor = System.Drawing.Color.Firebrick
		Me.btn_CerrarS.HoverState.Parent = Me.btn_CerrarS
		Me.btn_CerrarS.Location = New System.Drawing.Point(3, 557)
		Me.btn_CerrarS.Name = "btn_CerrarS"
		Me.btn_CerrarS.PressedColor = System.Drawing.Color.DarkRed
		Me.btn_CerrarS.ShadowDecoration.Parent = Me.btn_CerrarS
		Me.btn_CerrarS.Size = New System.Drawing.Size(245, 49)
		Me.btn_CerrarS.TabIndex = 5
		Me.btn_CerrarS.Text = "Cerrar sesión"
		'
		'btn_Ventas
		'
		Me.btn_Ventas.BackColor = System.Drawing.Color.Transparent
		Me.btn_Ventas.BorderRadius = 5
		Me.btn_Ventas.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
		Me.btn_Ventas.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(158, Byte), Integer))
		Me.btn_Ventas.CheckedState.Parent = Me.btn_Ventas
		Me.btn_Ventas.CustomImages.Parent = Me.btn_Ventas
		Me.trs_Aparecer.SetDecoration(Me.btn_Ventas, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.btn_Ventas.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
		Me.btn_Ventas.Font = New System.Drawing.Font("Segoe UI", 11.0!)
		Me.btn_Ventas.ForeColor = System.Drawing.Color.White
		Me.btn_Ventas.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(232, Byte), Integer))
		Me.btn_Ventas.HoverState.Parent = Me.btn_Ventas
		Me.btn_Ventas.Location = New System.Drawing.Point(3, 253)
		Me.btn_Ventas.Name = "btn_Ventas"
		Me.btn_Ventas.ShadowDecoration.Parent = Me.btn_Ventas
		Me.btn_Ventas.Size = New System.Drawing.Size(245, 49)
		Me.btn_Ventas.TabIndex = 4
		Me.btn_Ventas.Text = "Ventas"
		'
		'Personas
		'
		Me.Personas.BackColor = System.Drawing.Color.Transparent
		Me.Personas.BorderRadius = 5
		Me.Personas.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
		Me.Personas.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(158, Byte), Integer))
		Me.Personas.CheckedState.Parent = Me.Personas
		Me.Personas.CustomImages.Parent = Me.Personas
		Me.trs_Aparecer.SetDecoration(Me.Personas, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Personas.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
		Me.Personas.Font = New System.Drawing.Font("Segoe UI", 11.0!)
		Me.Personas.ForeColor = System.Drawing.Color.White
		Me.Personas.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(232, Byte), Integer))
		Me.Personas.HoverState.Parent = Me.Personas
		Me.Personas.Location = New System.Drawing.Point(3, 198)
		Me.Personas.Name = "Personas"
		Me.Personas.ShadowDecoration.Parent = Me.Personas
		Me.Personas.Size = New System.Drawing.Size(245, 49)
		Me.Personas.TabIndex = 3
		Me.Personas.Text = "Personas"
		'
		'btn_Articulos
		'
		Me.btn_Articulos.BackColor = System.Drawing.Color.Transparent
		Me.btn_Articulos.BorderRadius = 5
		Me.btn_Articulos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
		Me.btn_Articulos.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(158, Byte), Integer))
		Me.btn_Articulos.CheckedState.Parent = Me.btn_Articulos
		Me.btn_Articulos.CustomImages.Parent = Me.btn_Articulos
		Me.trs_Aparecer.SetDecoration(Me.btn_Articulos, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.btn_Articulos.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
		Me.btn_Articulos.Font = New System.Drawing.Font("Segoe UI", 11.0!)
		Me.btn_Articulos.ForeColor = System.Drawing.Color.White
		Me.btn_Articulos.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(232, Byte), Integer))
		Me.btn_Articulos.HoverState.Parent = Me.btn_Articulos
		Me.btn_Articulos.Location = New System.Drawing.Point(3, 143)
		Me.btn_Articulos.Name = "btn_Articulos"
		Me.btn_Articulos.ShadowDecoration.Parent = Me.btn_Articulos
		Me.btn_Articulos.Size = New System.Drawing.Size(245, 49)
		Me.btn_Articulos.TabIndex = 2
		Me.btn_Articulos.Text = "Artículos"
		'
		'btn_Equipos
		'
		Me.btn_Equipos.BackColor = System.Drawing.Color.Transparent
		Me.btn_Equipos.BorderRadius = 5
		Me.btn_Equipos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
		Me.btn_Equipos.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(158, Byte), Integer))
		Me.btn_Equipos.CheckedState.Parent = Me.btn_Equipos
		Me.btn_Equipos.CustomImages.Parent = Me.btn_Equipos
		Me.trs_Aparecer.SetDecoration(Me.btn_Equipos, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.btn_Equipos.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
		Me.btn_Equipos.Font = New System.Drawing.Font("Segoe UI", 11.0!)
		Me.btn_Equipos.ForeColor = System.Drawing.Color.White
		Me.btn_Equipos.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(232, Byte), Integer))
		Me.btn_Equipos.HoverState.Parent = Me.btn_Equipos
		Me.btn_Equipos.Location = New System.Drawing.Point(3, 88)
		Me.btn_Equipos.Name = "btn_Equipos"
		Me.btn_Equipos.ShadowDecoration.Parent = Me.btn_Equipos
		Me.btn_Equipos.Size = New System.Drawing.Size(245, 49)
		Me.btn_Equipos.TabIndex = 1
		Me.btn_Equipos.Text = "Equipos"
		'
		'btn_Home
		'
		Me.btn_Home.BackColor = System.Drawing.Color.Transparent
		Me.btn_Home.BorderRadius = 5
		Me.btn_Home.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
		Me.btn_Home.Checked = True
		Me.btn_Home.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(158, Byte), Integer))
		Me.btn_Home.CheckedState.Parent = Me.btn_Home
		Me.btn_Home.CustomImages.Parent = Me.btn_Home
		Me.trs_Aparecer.SetDecoration(Me.btn_Home, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.btn_Home.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
		Me.btn_Home.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Home.ForeColor = System.Drawing.Color.White
		Me.btn_Home.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(232, Byte), Integer))
		Me.btn_Home.HoverState.Parent = Me.btn_Home
		Me.btn_Home.Location = New System.Drawing.Point(3, 33)
		Me.btn_Home.Name = "btn_Home"
		Me.btn_Home.ShadowDecoration.Parent = Me.btn_Home
		Me.btn_Home.Size = New System.Drawing.Size(245, 49)
		Me.btn_Home.TabIndex = 0
		Me.btn_Home.Text = "Home"
		'
		'pnl_Filtros
		'
		Me.trs_Aparecer.SetDecoration(Me.pnl_Filtros, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.pnl_Filtros.Location = New System.Drawing.Point(158, 8)
		Me.pnl_Filtros.Name = "pnl_Filtros"
		Me.pnl_Filtros.ShadowDecoration.Parent = Me.pnl_Filtros
		Me.pnl_Filtros.Size = New System.Drawing.Size(427, 41)
		Me.pnl_Filtros.TabIndex = 1
		Me.pnl_Filtros.Visible = False
		'
		'lb_Quitar
		'
		Me.lb_Quitar.AutoSize = True
		Me.lb_Quitar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.trs_Aparecer.SetDecoration(Me.lb_Quitar, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.lb_Quitar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lb_Quitar.ForeColor = System.Drawing.Color.White
		Me.lb_Quitar.Location = New System.Drawing.Point(1048, 8)
		Me.lb_Quitar.Name = "lb_Quitar"
		Me.lb_Quitar.Size = New System.Drawing.Size(25, 30)
		Me.lb_Quitar.TabIndex = 2
		Me.lb_Quitar.Text = "X"
		'
		'Guna2CirclePictureBox1
		'
		Me.trs_Aparecer.SetDecoration(Me.Guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.White
		Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(12, 8)
		Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
		Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
		Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
		Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(38, 37)
		Me.Guna2CirclePictureBox1.TabIndex = 3
		Me.Guna2CirclePictureBox1.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.trs_Aparecer.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(56, 14)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(99, 21)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "CPC - Center"
		'
		'lb_Minimizar
		'
		Me.lb_Minimizar.AutoSize = True
		Me.lb_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.trs_Aparecer.SetDecoration(Me.lb_Minimizar, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.lb_Minimizar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lb_Minimizar.ForeColor = System.Drawing.Color.White
		Me.lb_Minimizar.Location = New System.Drawing.Point(1012, -1)
		Me.lb_Minimizar.Name = "lb_Minimizar"
		Me.lb_Minimizar.Size = New System.Drawing.Size(22, 30)
		Me.lb_Minimizar.TabIndex = 5
		Me.lb_Minimizar.Text = "_"
		'
		'pnl_Login
		'
		Me.pnl_Login.BackColor = System.Drawing.Color.Transparent
		Me.pnl_Login.BorderColor = System.Drawing.Color.Black
		Me.pnl_Login.BorderRadius = 15
		Me.pnl_Login.BorderThickness = 1
		Me.pnl_Login.Controls.Add(Me.Panel1)
		Me.pnl_Login.Controls.Add(Me.PictureBox3)
		Me.pnl_Login.Controls.Add(Me.PictureBox2)
		Me.pnl_Login.Controls.Add(Me.PictureBox1)
		Me.pnl_Login.Controls.Add(Me.Label3)
		Me.pnl_Login.Controls.Add(Me.Label2)
		Me.pnl_Login.Controls.Add(Me.txt_ConfirmPass)
		Me.pnl_Login.Controls.Add(Me.txt_Pass)
		Me.pnl_Login.Controls.Add(Me.txt_DNI)
		Me.pnl_Login.Controls.Add(Me.btn_IniciarS)
		Me.pnl_Login.Controls.Add(Me.Guna2Panel3)
		Me.trs_Aparecer.SetDecoration(Me.pnl_Login, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.pnl_Login.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
		Me.pnl_Login.Location = New System.Drawing.Point(151, 114)
		Me.pnl_Login.Name = "pnl_Login"
		Me.pnl_Login.ShadowDecoration.Parent = Me.pnl_Login
		Me.pnl_Login.Size = New System.Drawing.Size(785, 459)
		Me.pnl_Login.TabIndex = 6
		Me.pnl_Login.Visible = False
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
		Me.trs_Aparecer.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Panel1.Location = New System.Drawing.Point(337, 2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(18, 456)
		Me.Panel1.TabIndex = 11
		'
		'PictureBox3
		'
		Me.trs_Aparecer.SetDecoration(Me.PictureBox3, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.PictureBox3.Location = New System.Drawing.Point(422, 261)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(31, 32)
		Me.PictureBox3.TabIndex = 10
		Me.PictureBox3.TabStop = False
		'
		'PictureBox2
		'
		Me.trs_Aparecer.SetDecoration(Me.PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.PictureBox2.Location = New System.Drawing.Point(422, 208)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(31, 32)
		Me.PictureBox2.TabIndex = 9
		Me.PictureBox2.TabStop = False
		'
		'PictureBox1
		'
		Me.trs_Aparecer.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.PictureBox1.Location = New System.Drawing.Point(422, 155)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(31, 32)
		Me.PictureBox1.TabIndex = 8
		Me.PictureBox1.TabStop = False
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.trs_Aparecer.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.0!)
		Me.Label3.ForeColor = System.Drawing.Color.DarkOrchid
		Me.Label3.Location = New System.Drawing.Point(415, 29)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(107, 37)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "Lautaro"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.trs_Aparecer.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Location = New System.Drawing.Point(355, 32)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(70, 32)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Hola!"
		'
		'txt_ConfirmPass
		'
		Me.txt_ConfirmPass.BackColor = System.Drawing.Color.Transparent
		Me.txt_ConfirmPass.BorderRadius = 5
		Me.txt_ConfirmPass.BorderThickness = 0
		Me.txt_ConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.trs_Aparecer.SetDecoration(Me.txt_ConfirmPass, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.txt_ConfirmPass.DefaultText = ""
		Me.txt_ConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.txt_ConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.txt_ConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txt_ConfirmPass.DisabledState.Parent = Me.txt_ConfirmPass
		Me.txt_ConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txt_ConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txt_ConfirmPass.FocusedState.Parent = Me.txt_ConfirmPass
		Me.txt_ConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txt_ConfirmPass.HoverState.Parent = Me.txt_ConfirmPass
		Me.txt_ConfirmPass.Location = New System.Drawing.Point(472, 261)
		Me.txt_ConfirmPass.Name = "txt_ConfirmPass"
		Me.txt_ConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txt_ConfirmPass.PlaceholderText = ""
		Me.txt_ConfirmPass.SelectedText = ""
		Me.txt_ConfirmPass.ShadowDecoration.Parent = Me.txt_ConfirmPass
		Me.txt_ConfirmPass.Size = New System.Drawing.Size(204, 32)
		Me.txt_ConfirmPass.TabIndex = 5
		'
		'txt_Pass
		'
		Me.txt_Pass.BackColor = System.Drawing.Color.Transparent
		Me.txt_Pass.BorderRadius = 5
		Me.txt_Pass.BorderThickness = 0
		Me.txt_Pass.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.trs_Aparecer.SetDecoration(Me.txt_Pass, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.txt_Pass.DefaultText = ""
		Me.txt_Pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.txt_Pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.txt_Pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txt_Pass.DisabledState.Parent = Me.txt_Pass
		Me.txt_Pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txt_Pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txt_Pass.FocusedState.Parent = Me.txt_Pass
		Me.txt_Pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txt_Pass.HoverState.Parent = Me.txt_Pass
		Me.txt_Pass.Location = New System.Drawing.Point(472, 208)
		Me.txt_Pass.Name = "txt_Pass"
		Me.txt_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txt_Pass.PlaceholderText = ""
		Me.txt_Pass.SelectedText = ""
		Me.txt_Pass.ShadowDecoration.Parent = Me.txt_Pass
		Me.txt_Pass.Size = New System.Drawing.Size(204, 32)
		Me.txt_Pass.TabIndex = 4
		'
		'txt_DNI
		'
		Me.txt_DNI.BackColor = System.Drawing.Color.Transparent
		Me.txt_DNI.BorderRadius = 5
		Me.txt_DNI.BorderThickness = 0
		Me.txt_DNI.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.trs_Aparecer.SetDecoration(Me.txt_DNI, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.txt_DNI.DefaultText = ""
		Me.txt_DNI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.txt_DNI.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.txt_DNI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txt_DNI.DisabledState.Parent = Me.txt_DNI
		Me.txt_DNI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txt_DNI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txt_DNI.FocusedState.Parent = Me.txt_DNI
		Me.txt_DNI.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txt_DNI.HoverState.Parent = Me.txt_DNI
		Me.txt_DNI.Location = New System.Drawing.Point(472, 155)
		Me.txt_DNI.Name = "txt_DNI"
		Me.txt_DNI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txt_DNI.PlaceholderText = ""
		Me.txt_DNI.SelectedText = ""
		Me.txt_DNI.ShadowDecoration.Parent = Me.txt_DNI
		Me.txt_DNI.Size = New System.Drawing.Size(204, 32)
		Me.txt_DNI.TabIndex = 3
		'
		'btn_IniciarS
		'
		Me.btn_IniciarS.BackColor = System.Drawing.Color.Transparent
		Me.btn_IniciarS.BorderColor = System.Drawing.Color.DarkOrchid
		Me.btn_IniciarS.BorderRadius = 5
		Me.btn_IniciarS.BorderThickness = 1
		Me.btn_IniciarS.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(158, Byte), Integer))
		Me.btn_IniciarS.CheckedState.Parent = Me.btn_IniciarS
		Me.btn_IniciarS.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btn_IniciarS.CustomImages.Parent = Me.btn_IniciarS
		Me.trs_Aparecer.SetDecoration(Me.btn_IniciarS, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.btn_IniciarS.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
		Me.btn_IniciarS.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_IniciarS.ForeColor = System.Drawing.Color.White
		Me.btn_IniciarS.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(232, Byte), Integer))
		Me.btn_IniciarS.HoverState.Parent = Me.btn_IniciarS
		Me.btn_IniciarS.Location = New System.Drawing.Point(493, 314)
		Me.btn_IniciarS.Name = "btn_IniciarS"
		Me.btn_IniciarS.PressedColor = System.Drawing.Color.Lime
		Me.btn_IniciarS.ShadowDecoration.Parent = Me.btn_IniciarS
		Me.btn_IniciarS.Size = New System.Drawing.Size(169, 43)
		Me.btn_IniciarS.TabIndex = 1
		Me.btn_IniciarS.Text = "Iniciar Sesión"
		'
		'Guna2Panel3
		'
		Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
		Me.Guna2Panel3.BorderRadius = 15
		Me.trs_Aparecer.SetDecoration(Me.Guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Guna2Panel3.Location = New System.Drawing.Point(-1, 0)
		Me.Guna2Panel3.Name = "Guna2Panel3"
		Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
		Me.Guna2Panel3.Size = New System.Drawing.Size(350, 459)
		Me.Guna2Panel3.TabIndex = 2
		Me.Guna2Panel3.UseTransparentBackground = True
		'
		'lb_Bienvenida
		'
		Me.lb_Bienvenida.AutoSize = True
		Me.lb_Bienvenida.BackColor = System.Drawing.Color.Transparent
		Me.trs_Aparecer.SetDecoration(Me.lb_Bienvenida, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.lb_Bienvenida.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lb_Bienvenida.ForeColor = System.Drawing.Color.White
		Me.lb_Bienvenida.Location = New System.Drawing.Point(464, 315)
		Me.lb_Bienvenida.Name = "lb_Bienvenida"
		Me.lb_Bienvenida.Size = New System.Drawing.Size(216, 50)
		Me.lb_Bienvenida.TabIndex = 11
		Me.lb_Bienvenida.Text = "Bienvenid@"
		'
		'pic_Cargando
		'
		Me.pic_Cargando.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.pic_Cargando.Animated = True
		Me.pic_Cargando.AnimationSpeed = 3.0!
		Me.pic_Cargando.BackColor = System.Drawing.Color.Transparent
		Me.trs_Aparecer.SetDecoration(Me.pic_Cargando, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.pic_Cargando.FillColor = System.Drawing.Color.Transparent
		Me.pic_Cargando.FillThickness = 3
		Me.pic_Cargando.Location = New System.Drawing.Point(426, 264)
		Me.pic_Cargando.Name = "pic_Cargando"
		Me.pic_Cargando.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(158, Byte), Integer))
		Me.pic_Cargando.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
		Me.pic_Cargando.ProgressThickness = 3
		Me.pic_Cargando.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
		Me.pic_Cargando.ShadowDecoration.Parent = Me.pic_Cargando
		Me.pic_Cargando.Size = New System.Drawing.Size(40, 40)
		Me.pic_Cargando.TabIndex = 0
		Me.pic_Cargando.Value = 75
		'
		'tmr_Iniciar
		'
		Me.tmr_Iniciar.Interval = 2000
		'
		'pnl_Contenedor
		'
		Me.pnl_Contenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
		Me.trs_Aparecer.SetDecoration(Me.pnl_Contenedor, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.pnl_Contenedor.Location = New System.Drawing.Point(260, 14)
		Me.pnl_Contenedor.Name = "pnl_Contenedor"
		Me.pnl_Contenedor.Size = New System.Drawing.Size(823, 599)
		Me.pnl_Contenedor.TabIndex = 4
		Me.pnl_Contenedor.Visible = False
		'
		'Frm_Principal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(1085, 664)
		Me.Controls.Add(Me.lb_Minimizar)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Guna2CirclePictureBox1)
		Me.Controls.Add(Me.lb_Quitar)
		Me.Controls.Add(Me.pnl_Filtros)
		Me.Controls.Add(Me.pnl_Mover)
		Me.Controls.Add(Me.pnl_Principal)
		Me.Controls.Add(Me.pnl_Login)
		Me.Controls.Add(Me.lb_Bienvenida)
		Me.trs_Aparecer.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.DoubleBuffered = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "Frm_Principal"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Frm_Principal"
		Me.pnl_Principal.ResumeLayout(False)
		Me.pnl_Contenido.ResumeLayout(False)
		Me.pnl_Menu.ResumeLayout(False)
		CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnl_Login.ResumeLayout(False)
		Me.pnl_Login.PerformLayout()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
	Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
	Friend WithEvents pnl_Mover As Guna.UI2.WinForms.Guna2Panel
	Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
	Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
	Friend WithEvents trs_Aparecer As Guna.UI2.WinForms.Guna2Transition
	Friend WithEvents pnl_Principal As Guna.UI2.WinForms.Guna2Panel
	Friend WithEvents pnl_Filtros As Guna.UI2.WinForms.Guna2Panel
	Friend WithEvents pnl_Contenido As Guna.UI2.WinForms.Guna2Panel
	Friend WithEvents pnl_Menu As Guna.UI2.WinForms.Guna2Panel
	Friend WithEvents btn_CerrarS As Guna.UI2.WinForms.Guna2Button
	Friend WithEvents btn_Ventas As Guna.UI2.WinForms.Guna2Button
	Friend WithEvents Personas As Guna.UI2.WinForms.Guna2Button
	Friend WithEvents btn_Articulos As Guna.UI2.WinForms.Guna2Button
	Friend WithEvents btn_Equipos As Guna.UI2.WinForms.Guna2Button
	Friend WithEvents btn_Home As Guna.UI2.WinForms.Guna2Button
	Friend WithEvents lb_Quitar As Label
	Friend WithEvents lb_Minimizar As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
	Friend WithEvents btn_Ajustes As Guna.UI2.WinForms.Guna2Button
	Friend WithEvents pnl_Login As Guna.UI2.WinForms.Guna2Panel
	Friend WithEvents btn_IniciarS As Guna.UI2.WinForms.Guna2Button
	Friend WithEvents PictureBox3 As PictureBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents txt_ConfirmPass As Guna.UI2.WinForms.Guna2TextBox
	Friend WithEvents txt_Pass As Guna.UI2.WinForms.Guna2TextBox
	Friend WithEvents txt_DNI As Guna.UI2.WinForms.Guna2TextBox
	Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
	Friend WithEvents lb_Bienvenida As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents pic_Cargando As Guna.UI2.WinForms.Guna2CircleProgressBar
	Friend WithEvents tmr_Iniciar As Timer
	Friend WithEvents pnl_Contenedor As Panel
End Class
