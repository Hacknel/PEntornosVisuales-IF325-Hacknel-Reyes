﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIngresarDatos = New System.Windows.Forms.Button()
        Me.btnIngresarAlumno = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegresarAlInicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarDatosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraExternaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirLitsaDeAlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtiidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SISTEMA GESTOR DE NOTAS ACADEMICAS"
        '
        'btnIngresarDatos
        '
        Me.btnIngresarDatos.Location = New System.Drawing.Point(170, 130)
        Me.btnIngresarDatos.Name = "btnIngresarDatos"
        Me.btnIngresarDatos.Size = New System.Drawing.Size(122, 39)
        Me.btnIngresarDatos.TabIndex = 0
        Me.btnIngresarDatos.Text = "INGRESAR DATOS"
        Me.btnIngresarDatos.UseVisualStyleBackColor = True
        '
        'btnIngresarAlumno
        '
        Me.btnIngresarAlumno.Location = New System.Drawing.Point(462, 130)
        Me.btnIngresarAlumno.Name = "btnIngresarAlumno"
        Me.btnIngresarAlumno.Size = New System.Drawing.Size(122, 39)
        Me.btnIngresarAlumno.TabIndex = 2
        Me.btnIngresarAlumno.Text = "IMPRIMIR LISTA DE ALUMNOS"
        Me.btnIngresarAlumno.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(313, 194)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(122, 39)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "@HacknelR ©"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(313, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 39)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "CONSULTAR ALUMNOS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(487, 282)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "CALCULADORA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 159)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.InicioToolStripMenuItem, Me.IngresarDatosToolStripMenuItem, Me.UtiidadesToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(641, 24)
        Me.MenuStrip.TabIndex = 42
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SALIRToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(60, 20)
        Me.ToolStripMenuItem1.Text = "Archivo"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SALIRToolStripMenuItem.Text = "Salir"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarAlInicioToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'RegresarAlInicioToolStripMenuItem
        '
        Me.RegresarAlInicioToolStripMenuItem.Name = "RegresarAlInicioToolStripMenuItem"
        Me.RegresarAlInicioToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.RegresarAlInicioToolStripMenuItem.Text = "Regresar"
        '
        'IngresarDatosToolStripMenuItem
        '
        Me.IngresarDatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarDatosToolStripMenuItem1, Me.CalculadoraExternaToolStripMenuItem, Me.ImprimirLitsaDeAlumnosToolStripMenuItem})
        Me.IngresarDatosToolStripMenuItem.Name = "IngresarDatosToolStripMenuItem"
        Me.IngresarDatosToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.IngresarDatosToolStripMenuItem.Text = "Opciones"
        '
        'IngresarDatosToolStripMenuItem1
        '
        Me.IngresarDatosToolStripMenuItem1.Name = "IngresarDatosToolStripMenuItem1"
        Me.IngresarDatosToolStripMenuItem1.Size = New System.Drawing.Size(214, 22)
        Me.IngresarDatosToolStripMenuItem1.Text = "Ingresar Datos"
        '
        'CalculadoraExternaToolStripMenuItem
        '
        Me.CalculadoraExternaToolStripMenuItem.Name = "CalculadoraExternaToolStripMenuItem"
        Me.CalculadoraExternaToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.CalculadoraExternaToolStripMenuItem.Text = "Consultar Alumnos"
        '
        'ImprimirLitsaDeAlumnosToolStripMenuItem
        '
        Me.ImprimirLitsaDeAlumnosToolStripMenuItem.Name = "ImprimirLitsaDeAlumnosToolStripMenuItem"
        Me.ImprimirLitsaDeAlumnosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ImprimirLitsaDeAlumnosToolStripMenuItem.Text = "Imprimir Lista de Alumnos"
        '
        'UtiidadesToolStripMenuItem
        '
        Me.UtiidadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem})
        Me.UtiidadesToolStripMenuItem.Name = "UtiidadesToolStripMenuItem"
        Me.UtiidadesToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.UtiidadesToolStripMenuItem.Text = "Utiidades"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 318)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIngresarAlumno)
        Me.Controls.Add(Me.btnIngresarDatos)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Gestor de Notas Academicas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnIngresarDatos As Button
    Friend WithEvents btnIngresarAlumno As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegresarAlInicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarDatosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CalculadoraExternaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirLitsaDeAlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtiidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
End Class
