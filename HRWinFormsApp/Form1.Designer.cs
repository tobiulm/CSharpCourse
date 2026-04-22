namespace HRWinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainButton = new Button();
            outputLabel = new Label();
            eventHandlerAnfügenButton = new Button();
            eventHandlerLösenButton = new Button();
            SuspendLayout();
            // 
            // mainButton
            // 
            mainButton.Location = new Point(12, 29);
            mainButton.Name = "mainButton";
            mainButton.Size = new Size(1005, 45);
            mainButton.TabIndex = 0;
            mainButton.Text = "Klick mich!";
            mainButton.UseVisualStyleBackColor = true;
            mainButton.Click += mainButton_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(12, 600);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(0, 21);
            outputLabel.TabIndex = 1;
            // 
            // eventHandlerAnfügenButton
            // 
            eventHandlerAnfügenButton.Location = new Point(13, 89);
            eventHandlerAnfügenButton.Name = "eventHandlerAnfügenButton";
            eventHandlerAnfügenButton.Size = new Size(1005, 45);
            eventHandlerAnfügenButton.TabIndex = 2;
            eventHandlerAnfügenButton.Text = "EventHandler anfügen";
            eventHandlerAnfügenButton.UseVisualStyleBackColor = true;
            eventHandlerAnfügenButton.Click += eventHandlerAnfügenButton_Click;
            // 
            // eventHandlerLösenButton
            // 
            eventHandlerLösenButton.Location = new Point(13, 149);
            eventHandlerLösenButton.Name = "eventHandlerLösenButton";
            eventHandlerLösenButton.Size = new Size(1005, 45);
            eventHandlerLösenButton.TabIndex = 3;
            eventHandlerLösenButton.Text = "EventHandler lösen";
            eventHandlerLösenButton.UseVisualStyleBackColor = true;
            eventHandlerLösenButton.Click += eventHandlerLösenButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(eventHandlerLösenButton);
            Controls.Add(eventHandlerAnfügenButton);
            Controls.Add(outputLabel);
            Controls.Add(mainButton);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Personalverwaltung [NewElements]";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button mainButton;
        private Label outputLabel;
        private Button eventHandlerAnfügenButton;
        private Button eventHandlerLösenButton;
    }
}
