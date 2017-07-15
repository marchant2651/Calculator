<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculator))
        Me.btnSeven = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btnEight = New System.Windows.Forms.Button()
        Me.btnNine = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnSix = New System.Windows.Forms.Button()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDecimal = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSeven
        '
        Me.btnSeven.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSeven.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeven.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeven.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeven.Location = New System.Drawing.Point(35, 87)
        Me.btnSeven.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(60, 60)
        Me.btnSeven.TabIndex = 0
        Me.btnSeven.Text = "7"
        Me.btnSeven.UseVisualStyleBackColor = False
        '
        'txtDisplay
        '
        Me.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDisplay.Font = New System.Drawing.Font("MS Reference Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplay.Location = New System.Drawing.Point(35, 23)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDisplay.Size = New System.Drawing.Size(240, 41)
        Me.txtDisplay.TabIndex = 13
        Me.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnEight
        '
        Me.btnEight.BackColor = System.Drawing.Color.Gainsboro
        Me.btnEight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEight.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEight.Location = New System.Drawing.Point(95, 87)
        Me.btnEight.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(60, 60)
        Me.btnEight.TabIndex = 14
        Me.btnEight.Text = "8"
        Me.btnEight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEight.UseVisualStyleBackColor = False
        '
        'btnNine
        '
        Me.btnNine.BackColor = System.Drawing.Color.Gainsboro
        Me.btnNine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNine.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNine.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNine.Location = New System.Drawing.Point(155, 87)
        Me.btnNine.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(60, 60)
        Me.btnNine.TabIndex = 15
        Me.btnNine.Text = "9"
        Me.btnNine.UseVisualStyleBackColor = False
        '
        'btnFour
        '
        Me.btnFour.BackColor = System.Drawing.Color.Gainsboro
        Me.btnFour.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFour.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFour.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFour.Location = New System.Drawing.Point(35, 147)
        Me.btnFour.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(60, 60)
        Me.btnFour.TabIndex = 16
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = False
        '
        'btnFive
        '
        Me.btnFive.BackColor = System.Drawing.Color.Gainsboro
        Me.btnFive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFive.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFive.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFive.Location = New System.Drawing.Point(95, 147)
        Me.btnFive.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(60, 60)
        Me.btnFive.TabIndex = 17
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = False
        '
        'btnSix
        '
        Me.btnSix.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSix.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSix.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSix.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSix.Location = New System.Drawing.Point(155, 147)
        Me.btnSix.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(60, 60)
        Me.btnSix.TabIndex = 18
        Me.btnSix.Text = "6"
        Me.btnSix.UseVisualStyleBackColor = False
        '
        'btnOne
        '
        Me.btnOne.BackColor = System.Drawing.Color.Gainsboro
        Me.btnOne.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOne.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOne.Location = New System.Drawing.Point(35, 207)
        Me.btnOne.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(60, 60)
        Me.btnOne.TabIndex = 19
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = False
        '
        'btnTwo
        '
        Me.btnTwo.BackColor = System.Drawing.Color.Gainsboro
        Me.btnTwo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTwo.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwo.Location = New System.Drawing.Point(95, 207)
        Me.btnTwo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(60, 60)
        Me.btnTwo.TabIndex = 20
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = False
        '
        'btnThree
        '
        Me.btnThree.BackColor = System.Drawing.Color.Gainsboro
        Me.btnThree.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThree.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThree.Location = New System.Drawing.Point(155, 207)
        Me.btnThree.Margin = New System.Windows.Forms.Padding(0)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(60, 60)
        Me.btnThree.TabIndex = 21
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = False
        '
        'btnZero
        '
        Me.btnZero.BackColor = System.Drawing.Color.Gainsboro
        Me.btnZero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnZero.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZero.Location = New System.Drawing.Point(95, 267)
        Me.btnZero.Margin = New System.Windows.Forms.Padding(0)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(60, 60)
        Me.btnZero.TabIndex = 22
        Me.btnZero.Text = "0"
        Me.btnZero.UseVisualStyleBackColor = False
        '
        'btnPlus
        '
        Me.btnPlus.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(215, 267)
        Me.btnPlus.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(60, 60)
        Me.btnPlus.TabIndex = 23
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'btnEquals
        '
        Me.btnEquals.BackColor = System.Drawing.Color.Gainsboro
        Me.btnEquals.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEquals.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEquals.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEquals.Location = New System.Drawing.Point(155, 267)
        Me.btnEquals.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(60, 60)
        Me.btnEquals.TabIndex = 24
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gainsboro
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(122, 330)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(65, 65)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDecimal
        '
        Me.btnDecimal.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDecimal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDecimal.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecimal.Location = New System.Drawing.Point(35, 267)
        Me.btnDecimal.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDecimal.Name = "btnDecimal"
        Me.btnDecimal.Size = New System.Drawing.Size(60, 60)
        Me.btnDecimal.TabIndex = 26
        Me.btnDecimal.Text = "."
        Me.btnDecimal.UseVisualStyleBackColor = False
        '
        'btnMultiply
        '
        Me.btnMultiply.BackColor = System.Drawing.Color.Gainsboro
        Me.btnMultiply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.Location = New System.Drawing.Point(215, 147)
        Me.btnMultiply.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(60, 60)
        Me.btnMultiply.TabIndex = 27
        Me.btnMultiply.Text = "X"
        Me.btnMultiply.UseVisualStyleBackColor = False
        '
        'btnDivide
        '
        Me.btnDivide.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDivide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDivide.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(215, 87)
        Me.btnDivide.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(60, 60)
        Me.btnDivide.TabIndex = 28
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = False
        '
        'btnSubtract
        '
        Me.btnSubtract.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSubtract.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubtract.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtract.Location = New System.Drawing.Point(215, 207)
        Me.btnSubtract.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(60, 60)
        Me.btnSubtract.TabIndex = 29
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = False
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(321, 420)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnDecimal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEquals)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnZero)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.Controls.Add(Me.btnSix)
        Me.Controls.Add(Me.btnFive)
        Me.Controls.Add(Me.btnFour)
        Me.Controls.Add(Me.btnNine)
        Me.Controls.Add(Me.btnEight)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnSeven)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSeven As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnEight As Button
    Friend WithEvents btnNine As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnSix As Button
    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnZero As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnEquals As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDecimal As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnSubtract As Button
End Class
