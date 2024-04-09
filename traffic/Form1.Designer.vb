<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.color1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.color2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.color3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.color3, Me.color2, Me.color1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(573, 514)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'color1
        '
        Me.color1.BorderColor = System.Drawing.Color.Red
        Me.color1.FillColor = System.Drawing.Color.Red
        Me.color1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.color1.Location = New System.Drawing.Point(214, 35)
        Me.color1.Name = "color1"
        Me.color1.Size = New System.Drawing.Size(138, 118)
        '
        'color2
        '
        Me.color2.BorderColor = System.Drawing.Color.Yellow
        Me.color2.FillColor = System.Drawing.Color.Yellow
        Me.color2.FillGradientColor = System.Drawing.Color.Yellow
        Me.color2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.color2.Location = New System.Drawing.Point(217, 198)
        Me.color2.Name = "color2"
        Me.color2.Size = New System.Drawing.Size(138, 118)
        '
        'color3
        '
        Me.color3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.color3.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.color3.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.color3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.color3.Location = New System.Drawing.Point(216, 361)
        Me.color3.Name = "color3"
        Me.color3.Size = New System.Drawing.Size(138, 118)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 514)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents color1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents color3 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents color2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
