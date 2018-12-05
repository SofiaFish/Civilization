namespace WindowsFormsCiv
{
    partial class Civilization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lArmy = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.bSchool = new System.Windows.Forms.Button();
            this.bChurch = new System.Windows.Forms.Button();
            this.bBur = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lCountry = new System.Windows.Forms.Label();
            this.lTerritory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lHappiness = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lYear = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lTerr = new System.Windows.Forms.Label();
            this.lPopulation = new System.Windows.Forms.Label();
            this.lArm = new System.Windows.Forms.Label();
            this.lEducation = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lGold = new System.Windows.Forms.Label();
            this.lCorn = new System.Windows.Forms.Label();
            this.lStone = new System.Windows.Forms.Label();
            this.lbText = new System.Windows.Forms.ListBox();
            this.lReligion = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.bWar = new System.Windows.Forms.Button();
            this.bMove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bBur);
            this.groupBox1.Controls.Add(this.bChurch);
            this.groupBox1.Controls.Add(this.bSchool);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.lArmy);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lArmy
            // 
            this.lArmy.AutoSize = true;
            this.lArmy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lArmy.Location = new System.Drawing.Point(9, 16);
            this.lArmy.Name = "lArmy";
            this.lArmy.Size = new System.Drawing.Size(42, 18);
            this.lArmy.TabIndex = 0;
            this.lArmy.Text = "Army";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(73, 16);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(156, 45);
            this.trackBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Build";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bSchool
            // 
            this.bSchool.Location = new System.Drawing.Point(12, 96);
            this.bSchool.Name = "bSchool";
            this.bSchool.Size = new System.Drawing.Size(66, 23);
            this.bSchool.TabIndex = 3;
            this.bSchool.Text = "School";
            this.bSchool.UseVisualStyleBackColor = true;
            // 
            // bChurch
            // 
            this.bChurch.Location = new System.Drawing.Point(84, 96);
            this.bChurch.Name = "bChurch";
            this.bChurch.Size = new System.Drawing.Size(66, 23);
            this.bChurch.TabIndex = 4;
            this.bChurch.Text = "Church";
            this.bChurch.UseVisualStyleBackColor = true;
            // 
            // bBur
            // 
            this.bBur.Location = new System.Drawing.Point(156, 96);
            this.bBur.Name = "bBur";
            this.bBur.Size = new System.Drawing.Size(66, 23);
            this.bBur.TabIndex = 5;
            this.bBur.Text = "Bur";
            this.bBur.UseVisualStyleBackColor = true;
            this.bBur.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lReligion);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lEducation);
            this.groupBox2.Controls.Add(this.lArm);
            this.groupBox2.Controls.Add(this.lPopulation);
            this.groupBox2.Controls.Add(this.lTerr);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lYear);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lTerritory);
            this.groupBox2.Controls.Add(this.lCountry);
            this.groupBox2.Location = new System.Drawing.Point(257, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lCountry
            // 
            this.lCountry.AutoSize = true;
            this.lCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCountry.Location = new System.Drawing.Point(7, 16);
            this.lCountry.Name = "lCountry";
            this.lCountry.Size = new System.Drawing.Size(60, 18);
            this.lCountry.TabIndex = 0;
            this.lCountry.Text = "Country";
            // 
            // lTerritory
            // 
            this.lTerritory.AutoSize = true;
            this.lTerritory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTerritory.Location = new System.Drawing.Point(6, 45);
            this.lTerritory.Name = "lTerritory";
            this.lTerritory.Size = new System.Drawing.Size(61, 16);
            this.lTerritory.TabIndex = 1;
            this.lTerritory.Text = "Territory:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Population:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Army:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(21, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Resourses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gold:";
            // 
            // lHappiness
            // 
            this.lHappiness.AutoSize = true;
            this.lHappiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lHappiness.Location = new System.Drawing.Point(6, 80);
            this.lHappiness.Name = "lHappiness";
            this.lHappiness.Size = new System.Drawing.Size(39, 16);
            this.lHappiness.TabIndex = 6;
            this.lHappiness.Text = "Corn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Stone:";
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lYear.Location = new System.Drawing.Point(148, 16);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(40, 18);
            this.lYear.TabIndex = 8;
            this.lYear.Text = "1000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(194, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(136, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Education:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(137, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Happines:";
            // 
            // lTerr
            // 
            this.lTerr.AutoSize = true;
            this.lTerr.Location = new System.Drawing.Point(73, 48);
            this.lTerr.Name = "lTerr";
            this.lTerr.Size = new System.Drawing.Size(13, 13);
            this.lTerr.TabIndex = 12;
            this.lTerr.Text = "0";
            // 
            // lPopulation
            // 
            this.lPopulation.AutoSize = true;
            this.lPopulation.Location = new System.Drawing.Point(87, 76);
            this.lPopulation.Name = "lPopulation";
            this.lPopulation.Size = new System.Drawing.Size(13, 13);
            this.lPopulation.TabIndex = 13;
            this.lPopulation.Text = "0";
            // 
            // lArm
            // 
            this.lArm.AutoSize = true;
            this.lArm.Location = new System.Drawing.Point(54, 101);
            this.lArm.Name = "lArm";
            this.lArm.Size = new System.Drawing.Size(13, 13);
            this.lArm.TabIndex = 14;
            this.lArm.Text = "0";
            // 
            // lEducation
            // 
            this.lEducation.AutoSize = true;
            this.lEducation.Location = new System.Drawing.Point(213, 48);
            this.lEducation.Name = "lEducation";
            this.lEducation.Size = new System.Drawing.Size(13, 13);
            this.lEducation.TabIndex = 15;
            this.lEducation.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(213, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lStone);
            this.groupBox3.Controls.Add(this.lCorn);
            this.groupBox3.Controls.Add(this.lGold);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lHappiness);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(387, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(112, 167);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // lGold
            // 
            this.lGold.AutoSize = true;
            this.lGold.Location = new System.Drawing.Point(60, 47);
            this.lGold.Name = "lGold";
            this.lGold.Size = new System.Drawing.Size(13, 13);
            this.lGold.TabIndex = 17;
            this.lGold.Text = "0";
            // 
            // lCorn
            // 
            this.lCorn.AutoSize = true;
            this.lCorn.Location = new System.Drawing.Point(60, 80);
            this.lCorn.Name = "lCorn";
            this.lCorn.Size = new System.Drawing.Size(13, 13);
            this.lCorn.TabIndex = 18;
            this.lCorn.Text = "0";
            // 
            // lStone
            // 
            this.lStone.AutoSize = true;
            this.lStone.Location = new System.Drawing.Point(60, 115);
            this.lStone.Name = "lStone";
            this.lStone.Size = new System.Drawing.Size(13, 13);
            this.lStone.TabIndex = 19;
            this.lStone.Text = "0";
            // 
            // lbText
            // 
            this.lbText.FormattingEnabled = true;
            this.lbText.Location = new System.Drawing.Point(257, 156);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(124, 134);
            this.lbText.TabIndex = 9;
            // 
            // lReligion
            // 
            this.lReligion.AutoSize = true;
            this.lReligion.Location = new System.Drawing.Point(213, 76);
            this.lReligion.Name = "lReligion";
            this.lReligion.Size = new System.Drawing.Size(13, 13);
            this.lReligion.TabIndex = 18;
            this.lReligion.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(136, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 16);
            this.label19.TabIndex = 17;
            this.label19.Text = "Religion:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bWar);
            this.groupBox4.Controls.Add(this.trackBar3);
            this.groupBox4.Controls.Add(this.trackBar2);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(13, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 167);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(97, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "War";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(9, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 32);
            this.label11.TabIndex = 19;
            this.label11.Text = "Captureted\r\nterritories:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(9, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Warrios:";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(84, 44);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(134, 45);
            this.trackBar2.TabIndex = 6;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(84, 95);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(134, 45);
            this.trackBar3.TabIndex = 21;
            // 
            // bWar
            // 
            this.bWar.Location = new System.Drawing.Point(84, 138);
            this.bWar.Name = "bWar";
            this.bWar.Size = new System.Drawing.Size(66, 23);
            this.bWar.TabIndex = 6;
            this.bWar.Text = "WAR!!!";
            this.bWar.UseVisualStyleBackColor = true;
            // 
            // bMove
            // 
            this.bMove.Location = new System.Drawing.Point(277, 293);
            this.bMove.Name = "bMove";
            this.bMove.Size = new System.Drawing.Size(80, 23);
            this.bMove.TabIndex = 6;
            this.bMove.Text = "Move";
            this.bMove.UseVisualStyleBackColor = true;
            // 
            // Civilization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 330);
            this.Controls.Add(this.bMove);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Civilization";
            this.Text = "Civilization";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bBur;
        private System.Windows.Forms.Button bChurch;
        private System.Windows.Forms.Button bSchool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lArmy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lTerritory;
        private System.Windows.Forms.Label lCountry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lHappiness;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lEducation;
        private System.Windows.Forms.Label lArm;
        private System.Windows.Forms.Label lPopulation;
        private System.Windows.Forms.Label lTerr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lStone;
        private System.Windows.Forms.Label lCorn;
        private System.Windows.Forms.Label lGold;
        private System.Windows.Forms.ListBox lbText;
        private System.Windows.Forms.Label lReligion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bWar;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bMove;
    }
}

