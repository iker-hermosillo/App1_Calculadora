<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TXTBXnum1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SUMAR = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TXTBXnum2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RESTAR = New System.Windows.Forms.Button()
        Me.MULTIPLICAR = New System.Windows.Forms.Button()
        Me.DIVIDIR = New System.Windows.Forms.Button()
        Me.boton9 = New System.Windows.Forms.Button()
        Me.boton4 = New System.Windows.Forms.Button()
        Me.boton5 = New System.Windows.Forms.Button()
        Me.boton6 = New System.Windows.Forms.Button()
        Me.boton7 = New System.Windows.Forms.Button()
        Me.boton8 = New System.Windows.Forms.Button()
        Me.boton0 = New System.Windows.Forms.Button()
        Me.boton3 = New System.Windows.Forms.Button()
        Me.boton2 = New System.Windows.Forms.Button()
        Me.boton1 = New System.Windows.Forms.Button()
        Me.botonC = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTBXnum1
        '
        Me.TXTBXnum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBXnum1.Location = New System.Drawing.Point(142, 20)
        Me.TXTBXnum1.Name = "TXTBXnum1"
        Me.TXTBXnum1.Size = New System.Drawing.Size(182, 31)
        Me.TXTBXnum1.TabIndex = 0
        Me.TXTBXnum1.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NUMERO 1"
        '
        'SUMAR
        '
        Me.SUMAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUMAR.Location = New System.Drawing.Point(728, 15)
        Me.SUMAR.Name = "SUMAR"
        Me.SUMAR.Size = New System.Drawing.Size(57, 55)
        Me.SUMAR.TabIndex = 2
        Me.SUMAR.Text = "+"
        Me.SUMAR.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NUMERO 2"
        '
        'TXTBXnum2
        '
        Me.TXTBXnum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBXnum2.Location = New System.Drawing.Point(142, 66)
        Me.TXTBXnum2.Name = "TXTBXnum2"
        Me.TXTBXnum2.Size = New System.Drawing.Size(182, 31)
        Me.TXTBXnum2.TabIndex = 4
        Me.TXTBXnum2.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(142, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Tag = ""
        Me.Label4.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "RESULTADO:"
        '
        'RESTAR
        '
        Me.RESTAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESTAR.Location = New System.Drawing.Point(728, 76)
        Me.RESTAR.Name = "RESTAR"
        Me.RESTAR.Size = New System.Drawing.Size(57, 55)
        Me.RESTAR.TabIndex = 8
        Me.RESTAR.Text = "-"
        Me.RESTAR.UseVisualStyleBackColor = True
        '
        'MULTIPLICAR
        '
        Me.MULTIPLICAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MULTIPLICAR.Location = New System.Drawing.Point(728, 137)
        Me.MULTIPLICAR.Name = "MULTIPLICAR"
        Me.MULTIPLICAR.Size = New System.Drawing.Size(57, 55)
        Me.MULTIPLICAR.TabIndex = 9
        Me.MULTIPLICAR.Text = "x"
        Me.MULTIPLICAR.UseVisualStyleBackColor = True
        '
        'DIVIDIR
        '
        Me.DIVIDIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DIVIDIR.Location = New System.Drawing.Point(728, 198)
        Me.DIVIDIR.Name = "DIVIDIR"
        Me.DIVIDIR.Size = New System.Drawing.Size(57, 55)
        Me.DIVIDIR.TabIndex = 10
        Me.DIVIDIR.Text = "÷"
        Me.DIVIDIR.UseVisualStyleBackColor = True
        '
        'boton9
        '
        Me.boton9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton9.Location = New System.Drawing.Point(633, 15)
        Me.boton9.Name = "boton9"
        Me.boton9.Size = New System.Drawing.Size(57, 55)
        Me.boton9.TabIndex = 12
        Me.boton9.Text = "9"
        Me.boton9.UseVisualStyleBackColor = True
        '
        'boton4
        '
        Me.boton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton4.Location = New System.Drawing.Point(507, 76)
        Me.boton4.Name = "boton4"
        Me.boton4.Size = New System.Drawing.Size(57, 55)
        Me.boton4.TabIndex = 13
        Me.boton4.Text = "4"
        Me.boton4.UseVisualStyleBackColor = True
        '
        'boton5
        '
        Me.boton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton5.Location = New System.Drawing.Point(570, 76)
        Me.boton5.Name = "boton5"
        Me.boton5.Size = New System.Drawing.Size(57, 55)
        Me.boton5.TabIndex = 14
        Me.boton5.Text = "5"
        Me.boton5.UseVisualStyleBackColor = True
        '
        'boton6
        '
        Me.boton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton6.Location = New System.Drawing.Point(633, 76)
        Me.boton6.Name = "boton6"
        Me.boton6.Size = New System.Drawing.Size(57, 55)
        Me.boton6.TabIndex = 15
        Me.boton6.Text = "6"
        Me.boton6.UseVisualStyleBackColor = True
        '
        'boton7
        '
        Me.boton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton7.Location = New System.Drawing.Point(507, 15)
        Me.boton7.Name = "boton7"
        Me.boton7.Size = New System.Drawing.Size(57, 55)
        Me.boton7.TabIndex = 16
        Me.boton7.Text = "7"
        Me.boton7.UseVisualStyleBackColor = True
        '
        'boton8
        '
        Me.boton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton8.Location = New System.Drawing.Point(570, 15)
        Me.boton8.Name = "boton8"
        Me.boton8.Size = New System.Drawing.Size(57, 55)
        Me.boton8.TabIndex = 17
        Me.boton8.Text = "8"
        Me.boton8.UseVisualStyleBackColor = True
        '
        'boton0
        '
        Me.boton0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton0.Location = New System.Drawing.Point(570, 198)
        Me.boton0.Name = "boton0"
        Me.boton0.Size = New System.Drawing.Size(57, 55)
        Me.boton0.TabIndex = 18
        Me.boton0.Text = "0"
        Me.boton0.UseVisualStyleBackColor = True
        '
        'boton3
        '
        Me.boton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton3.Location = New System.Drawing.Point(633, 137)
        Me.boton3.Name = "boton3"
        Me.boton3.Size = New System.Drawing.Size(57, 55)
        Me.boton3.TabIndex = 19
        Me.boton3.Text = "3"
        Me.boton3.UseVisualStyleBackColor = True
        '
        'boton2
        '
        Me.boton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton2.Location = New System.Drawing.Point(570, 137)
        Me.boton2.Name = "boton2"
        Me.boton2.Size = New System.Drawing.Size(57, 55)
        Me.boton2.TabIndex = 20
        Me.boton2.Text = "2"
        Me.boton2.UseVisualStyleBackColor = True
        '
        'boton1
        '
        Me.boton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton1.Location = New System.Drawing.Point(507, 137)
        Me.boton1.Name = "boton1"
        Me.boton1.Size = New System.Drawing.Size(57, 55)
        Me.boton1.TabIndex = 21
        Me.boton1.Text = "1"
        Me.boton1.UseVisualStyleBackColor = True
        '
        'botonC
        '
        Me.botonC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonC.Location = New System.Drawing.Point(633, 197)
        Me.botonC.Name = "botonC"
        Me.botonC.Size = New System.Drawing.Size(57, 55)
        Me.botonC.TabIndex = 22
        Me.botonC.Text = "C"
        Me.botonC.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(507, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 55)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(344, 30)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 24
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(344, 72)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 25
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(794, 264)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.botonC)
        Me.Controls.Add(Me.boton1)
        Me.Controls.Add(Me.boton2)
        Me.Controls.Add(Me.boton3)
        Me.Controls.Add(Me.boton0)
        Me.Controls.Add(Me.boton8)
        Me.Controls.Add(Me.boton7)
        Me.Controls.Add(Me.boton6)
        Me.Controls.Add(Me.boton5)
        Me.Controls.Add(Me.boton4)
        Me.Controls.Add(Me.boton9)
        Me.Controls.Add(Me.DIVIDIR)
        Me.Controls.Add(Me.MULTIPLICAR)
        Me.Controls.Add(Me.RESTAR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXTBXnum2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SUMAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTBXnum1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTBXnum1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SUMAR As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents TXTBXnum2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RESTAR As Button
    Friend WithEvents MULTIPLICAR As Button
    Friend WithEvents DIVIDIR As Button
    Friend WithEvents boton9 As Button
    Friend WithEvents boton4 As Button
    Friend WithEvents boton5 As Button
    Friend WithEvents boton6 As Button
    Friend WithEvents boton7 As Button
    Friend WithEvents boton8 As Button
    Friend WithEvents boton0 As Button
    Friend WithEvents boton3 As Button
    Friend WithEvents boton2 As Button
    Friend WithEvents boton1 As Button
    Friend WithEvents botonC As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
