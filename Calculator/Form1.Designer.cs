namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Dock = System.Windows.Forms.DockStyle.Top;
            this.display.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(488, 51);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnDivide, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnPoint, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnZero, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAllClear, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMultiply, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSubstract, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNine, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSeven, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOne, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnTwo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnThree, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFour, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSix, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFive, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(467, 399);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDivide.Location = new System.Drawing.Point(351, 300);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(110, 93);
            this.btnDivide.TabIndex = 17;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPoint.Location = new System.Drawing.Point(235, 300);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(110, 93);
            this.btnPoint.TabIndex = 16;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnZero.Location = new System.Drawing.Point(119, 300);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(110, 93);
            this.btnZero.TabIndex = 15;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnAllClear
            // 
            this.btnAllClear.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAllClear.Location = new System.Drawing.Point(3, 300);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(110, 93);
            this.btnAllClear.TabIndex = 14;
            this.btnAllClear.Text = "AC";
            this.btnAllClear.UseVisualStyleBackColor = true;
            this.btnAllClear.Click += new System.EventHandler(this.btnAllClear_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMultiply.Location = new System.Drawing.Point(351, 201);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(110, 93);
            this.btnMultiply.TabIndex = 13;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSubstract.Location = new System.Drawing.Point(351, 102);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(110, 93);
            this.btnSubstract.TabIndex = 12;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(351, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 93);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNine
            // 
            this.btnNine.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNine.Location = new System.Drawing.Point(235, 3);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(110, 93);
            this.btnNine.TabIndex = 10;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEight.Location = new System.Drawing.Point(119, 3);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(110, 93);
            this.btnEight.TabIndex = 9;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSeven.Location = new System.Drawing.Point(3, 3);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(110, 93);
            this.btnSeven.TabIndex = 8;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOne.Location = new System.Drawing.Point(3, 201);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(110, 93);
            this.btnOne.TabIndex = 2;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTwo.Location = new System.Drawing.Point(119, 201);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(110, 93);
            this.btnTwo.TabIndex = 3;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnThree.Location = new System.Drawing.Point(235, 201);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(110, 93);
            this.btnThree.TabIndex = 4;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnFour
            // 
            this.btnFour.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFour.Location = new System.Drawing.Point(3, 102);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(110, 93);
            this.btnFour.TabIndex = 5;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnSix
            // 
            this.btnSix.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSix.Location = new System.Drawing.Point(235, 102);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(110, 93);
            this.btnSix.TabIndex = 7;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFive.Location = new System.Drawing.Point(119, 102);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(110, 93);
            this.btnFive.TabIndex = 6;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnResult
            // 
            this.btnResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnResult.Location = new System.Drawing.Point(0, 475);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(488, 62);
            this.btnResult.TabIndex = 0;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 537);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
    }
}

