using System;

namespace Calc
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableOperandPanel = new System.Windows.Forms.TableLayoutPanel();
            this.operandNineButton = new System.Windows.Forms.Button();
            this.operandEightButton = new System.Windows.Forms.Button();
            this.operandSevenButton = new System.Windows.Forms.Button();
            this.operandSixButton = new System.Windows.Forms.Button();
            this.operandFiveButton = new System.Windows.Forms.Button();
            this.operandFourButton = new System.Windows.Forms.Button();
            this.operandThreeButton = new System.Windows.Forms.Button();
            this.operandOneButton = new System.Windows.Forms.Button();
            this.operandTwoButton = new System.Windows.Forms.Button();
            this.tableOperatorPanel = new System.Windows.Forms.TableLayoutPanel();
            this.divisionButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.equallyButton = new System.Windows.Forms.Button();
            this.passivTextBox = new System.Windows.Forms.RichTextBox();
            this.operandZeroButton = new System.Windows.Forms.Button();
            this.activTextBox = new System.Windows.Forms.RichTextBox();
            this.clearEntryButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.tableOperandPanel.SuspendLayout();
            this.tableOperatorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableOperandPanel
            // 
            this.tableOperandPanel.ColumnCount = 3;
            this.tableOperandPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOperandPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOperandPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableOperandPanel.Controls.Add(this.operandNineButton, 2, 2);
            this.tableOperandPanel.Controls.Add(this.operandEightButton, 1, 2);
            this.tableOperandPanel.Controls.Add(this.operandSevenButton, 0, 2);
            this.tableOperandPanel.Controls.Add(this.operandZeroButton, 1, 3);
            this.tableOperandPanel.Controls.Add(this.operandSixButton, 2, 1);
            this.tableOperandPanel.Controls.Add(this.operandFiveButton, 1, 1);
            this.tableOperandPanel.Controls.Add(this.operandFourButton, 0, 1);
            this.tableOperandPanel.Controls.Add(this.operandThreeButton, 2, 0);
            this.tableOperandPanel.Controls.Add(this.operandOneButton, 0, 0);
            this.tableOperandPanel.Controls.Add(this.operandTwoButton, 1, 0);
            this.tableOperandPanel.Location = new System.Drawing.Point(12, 84);
            this.tableOperandPanel.Name = "tableOperandPanel";
            this.tableOperandPanel.RowCount = 4;
            this.tableOperandPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.93388F));
            this.tableOperandPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.06612F));
            this.tableOperandPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableOperandPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableOperandPanel.Size = new System.Drawing.Size(207, 215);
            this.tableOperandPanel.TabIndex = 0;
            // 
            // operandNineButton
            // 
            this.operandNineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operandNineButton.Location = new System.Drawing.Point(141, 113);
            this.operandNineButton.Name = "operandNineButton";
            this.operandNineButton.Size = new System.Drawing.Size(62, 49);
            this.operandNineButton.TabIndex = 8;
            this.operandNineButton.Text = "9";
            this.operandNineButton.UseVisualStyleBackColor = true;
            this.operandNineButton.Click += new System.EventHandler(this.OperandOneClick);
            // 
            // operandEightButton
            // 
            this.operandEightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operandEightButton.Location = new System.Drawing.Point(72, 113);
            this.operandEightButton.Name = "operandEightButton";
            this.operandEightButton.Size = new System.Drawing.Size(62, 49);
            this.operandEightButton.TabIndex = 7;
            this.operandEightButton.Text = "8";
            this.operandEightButton.UseVisualStyleBackColor = true;
            this.operandEightButton.Click += new System.EventHandler(this.OperandOneClick);
            // 
            // operandSevenButton
            // 
            this.operandSevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operandSevenButton.Location = new System.Drawing.Point(3, 113);
            this.operandSevenButton.Name = "operandSevenButton";
            this.operandSevenButton.Size = new System.Drawing.Size(62, 49);
            this.operandSevenButton.TabIndex = 6;
            this.operandSevenButton.Text = "7";
            this.operandSevenButton.UseVisualStyleBackColor = true;
            this.operandSevenButton.Click += new System.EventHandler(this.OperandOneClick);
            // 
            // operandSixButton
            // 
            this.operandSixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operandSixButton.Location = new System.Drawing.Point(141, 56);
            this.operandSixButton.Name = "operandSixButton";
            this.operandSixButton.Size = new System.Drawing.Size(62, 51);
            this.operandSixButton.TabIndex = 5;
            this.operandSixButton.Text = "6";
            this.operandSixButton.UseVisualStyleBackColor = true;
            this.operandSixButton.Click += new System.EventHandler(this.OperandOneClick);
            // 
            // operandFiveButton
            // 
            this.operandFiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operandFiveButton.Location = new System.Drawing.Point(72, 56);
            this.operandFiveButton.Name = "operandFiveButton";
            this.operandFiveButton.Size = new System.Drawing.Size(62, 51);
            this.operandFiveButton.TabIndex = 4;
            this.operandFiveButton.Text = "5";
            this.operandFiveButton.UseVisualStyleBackColor = true;
            this.operandFiveButton.Click += new System.EventHandler(this.OperandOneClick);
            // 
            // operandFourButton
            // 
            this.operandFourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operandFourButton.Location = new System.Drawing.Point(3, 56);
            this.operandFourButton.Name = "operandFourButton";
            this.operandFourButton.Size = new System.Drawing.Size(62, 51);
            this.operandFourButton.TabIndex = 3;
            this.operandFourButton.Text = "4";
            this.operandFourButton.UseVisualStyleBackColor = true;
            this.operandFourButton.Click += new System.EventHandler(this.OperandOneClick);
            // 
            // operandThreeButton
            // 
            this.operandThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operandThreeButton.Location = new System.Drawing.Point(141, 3);
            this.operandThreeButton.Name = "operandThreeButton";
            this.operandThreeButton.Size = new System.Drawing.Size(62, 47);
            this.operandThreeButton.TabIndex = 2;
            this.operandThreeButton.Text = "3";
            this.operandThreeButton.UseVisualStyleBackColor = true;
            this.operandThreeButton.Click += new System.EventHandler(this.OperandOneClick);
            // 
            // operandOneButton
            // 
            this.operandOneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operandOneButton.Location = new System.Drawing.Point(3, 3);
            this.operandOneButton.Name = "operandOneButton";
            this.operandOneButton.Size = new System.Drawing.Size(63, 47);
            this.operandOneButton.TabIndex = 0;
            this.operandOneButton.Text = "1";
            this.operandOneButton.UseVisualStyleBackColor = true;
            this.operandOneButton.Click += new System.EventHandler(this.OperandOneClick);
            // 
            // operandTwoButton
            // 
            this.operandTwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operandTwoButton.Location = new System.Drawing.Point(72, 3);
            this.operandTwoButton.Name = "operandTwoButton";
            this.operandTwoButton.Size = new System.Drawing.Size(62, 47);
            this.operandTwoButton.TabIndex = 1;
            this.operandTwoButton.Text = "2";
            this.operandTwoButton.UseVisualStyleBackColor = true;
            this.operandTwoButton.Click += new System.EventHandler(this.OperandOneClick);
            // 
            // tableOperatorPanel
            // 
            this.tableOperatorPanel.ColumnCount = 1;
            this.tableOperatorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOperatorPanel.Controls.Add(this.divisionButton, 0, 3);
            this.tableOperatorPanel.Controls.Add(this.plusButton, 0, 0);
            this.tableOperatorPanel.Controls.Add(this.minusButton, 0, 1);
            this.tableOperatorPanel.Controls.Add(this.multiplicationButton, 0, 2);
            this.tableOperatorPanel.Controls.Add(this.equallyButton, 0, 4);
            this.tableOperatorPanel.Location = new System.Drawing.Point(290, 84);
            this.tableOperatorPanel.Name = "tableOperatorPanel";
            this.tableOperatorPanel.RowCount = 5;
            this.tableOperatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.41177F));
            this.tableOperatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.58823F));
            this.tableOperatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableOperatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableOperatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableOperatorPanel.Size = new System.Drawing.Size(68, 212);
            this.tableOperatorPanel.TabIndex = 1;
            // 
            // divisionButton
            // 
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divisionButton.Location = new System.Drawing.Point(3, 128);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(62, 37);
            this.divisionButton.TabIndex = 13;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.OperatorOneClick);
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusButton.Location = new System.Drawing.Point(3, 3);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(62, 36);
            this.plusButton.TabIndex = 10;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.OperatorOneClick);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusButton.Location = new System.Drawing.Point(3, 45);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(62, 37);
            this.minusButton.TabIndex = 11;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.OperatorOneClick);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplicationButton.Location = new System.Drawing.Point(3, 88);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(62, 34);
            this.multiplicationButton.TabIndex = 12;
            this.multiplicationButton.Text = "*";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.OperatorOneClick);
            // 
            // equallyButton
            // 
            this.equallyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equallyButton.Location = new System.Drawing.Point(3, 171);
            this.equallyButton.Name = "equallyButton";
            this.equallyButton.Size = new System.Drawing.Size(62, 38);
            this.equallyButton.TabIndex = 14;
            this.equallyButton.Text = "=";
            this.equallyButton.UseVisualStyleBackColor = true;
            this.equallyButton.Click += new System.EventHandler(this.Result);
            // 
            // passivTextBox
            // 
            this.passivTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passivTextBox.Location = new System.Drawing.Point(3, 13);
            this.passivTextBox.Name = "passivTextBox";
            this.passivTextBox.ReadOnly = true;
            this.passivTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.passivTextBox.Size = new System.Drawing.Size(370, 27);
            this.passivTextBox.TabIndex = 2;
            this.passivTextBox.TabStop = false;
            this.passivTextBox.Text = "";
            // 
            // operandZeroButton
            // 
            this.operandZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operandZeroButton.Location = new System.Drawing.Point(72, 168);
            this.operandZeroButton.Name = "operandZeroButton";
            this.operandZeroButton.Size = new System.Drawing.Size(61, 44);
            this.operandZeroButton.TabIndex = 9;
            this.operandZeroButton.Text = "0";
            this.operandZeroButton.UseVisualStyleBackColor = true;
            this.operandZeroButton.Click += new System.EventHandler(this.OperandOneClick);
            // 
            // activTextBox
            // 
            this.activTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activTextBox.Location = new System.Drawing.Point(85, 46);
            this.activTextBox.Name = "activTextBox";
            this.activTextBox.ReadOnly = true;
            this.activTextBox.Size = new System.Drawing.Size(207, 32);
            this.activTextBox.TabIndex = 4;
            this.activTextBox.TabStop = false;
            this.activTextBox.Text = "";
            // 
            // clearEntryButton
            // 
            this.clearEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearEntryButton.Location = new System.Drawing.Point(298, 46);
            this.clearEntryButton.Name = "clearEntryButton";
            this.clearEntryButton.Size = new System.Drawing.Size(60, 29);
            this.clearEntryButton.TabIndex = 16;
            this.clearEntryButton.Text = "CE";
            this.clearEntryButton.UseVisualStyleBackColor = true;
            this.clearEntryButton.Click += new System.EventHandler(this.ClearEntryButtomClick);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(12, 46);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(60, 29);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtomClick);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(375, 311);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.clearEntryButton);
            this.Controls.Add(this.activTextBox);
            this.Controls.Add(this.passivTextBox);
            this.Controls.Add(this.tableOperatorPanel);
            this.Controls.Add(this.tableOperandPanel);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.tableOperandPanel.ResumeLayout(false);
            this.tableOperatorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableOperandPanel;
        private System.Windows.Forms.Button operandNineButton;
        private System.Windows.Forms.Button operandEightButton;
        private System.Windows.Forms.Button operandSevenButton;
        private System.Windows.Forms.Button operandSixButton;
        private System.Windows.Forms.Button operandFiveButton;
        private System.Windows.Forms.Button operandFourButton;
        private System.Windows.Forms.Button operandThreeButton;
        private System.Windows.Forms.Button operandOneButton;
        private System.Windows.Forms.Button operandTwoButton;
        private System.Windows.Forms.TableLayoutPanel tableOperatorPanel;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button equallyButton;
        private System.Windows.Forms.RichTextBox passivTextBox;
        private System.Windows.Forms.Button operandZeroButton;
        private System.Windows.Forms.RichTextBox activTextBox;
        private System.Windows.Forms.Button clearEntryButton;
        private System.Windows.Forms.Button clearButton;

    }
}

