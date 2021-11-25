﻿
namespace TelaMenuPIM.Paginas
{
    partial class PgAnalytics
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PgAnalytics));
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuChartCanvas1 = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.label5 = new System.Windows.Forms.Label();
            this.LineQuartos = new Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart(this.components);
            this.bunifuPanel4 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.CircleEstoqueProgress = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.bunifuPanel5 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuChartCanvas2 = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.label7 = new System.Windows.Forms.Label();
            this.BarrasGanhos = new Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart(this.components);
            this.bunifuPanel6 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.CircleQuartoProgess = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel4.SuspendLayout();
            this.bunifuPanel5.SuspendLayout();
            this.bunifuPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 20;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.bunifuChartCanvas1);
            this.bunifuPanel2.Controls.Add(this.label5);
            this.bunifuPanel2.Location = new System.Drawing.Point(24, 141);
            this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(791, 408);
            this.bunifuPanel2.TabIndex = 4;
            // 
            // bunifuChartCanvas1
            // 
            this.bunifuChartCanvas1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuChartCanvas1.AnimationDuration = 1000;
            this.bunifuChartCanvas1.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.linear;
            this.bunifuChartCanvas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.bunifuChartCanvas1.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.bunifuChartCanvas1.Labels = new string[] {
        "1/12",
        "2/12",
        "3/12",
        "4/12",
        "5/12",
        "6/12",
        "7/12",
        "8/12",
        "9/12",
        "10/12",
        "11/12",
        "12/12"};
            this.bunifuChartCanvas1.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.bunifuChartCanvas1.LegendDisplay = true;
            this.bunifuChartCanvas1.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuChartCanvas1.LegendForeColor = System.Drawing.Color.DarkGray;
            this.bunifuChartCanvas1.LegendFullWidth = true;
            this.bunifuChartCanvas1.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas1.LegendRevese = false;
            this.bunifuChartCanvas1.LegendRTL = false;
            this.bunifuChartCanvas1.Location = new System.Drawing.Point(8, 60);
            this.bunifuChartCanvas1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuChartCanvas1.Name = "bunifuChartCanvas1";
            this.bunifuChartCanvas1.ShowXAxis = true;
            this.bunifuChartCanvas1.ShowYAxis = true;
            this.bunifuChartCanvas1.Size = new System.Drawing.Size(772, 331);
            this.bunifuChartCanvas1.TabIndex = 0;
            this.bunifuChartCanvas1.Title = "";
            this.bunifuChartCanvas1.TitleLineHeight = 1.2D;
            this.bunifuChartCanvas1.TitlePadding = 0;
            this.bunifuChartCanvas1.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas1.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuChartCanvas1.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.bunifuChartCanvas1.TooltipsEnabled = true;
            this.bunifuChartCanvas1.XAxesBeginAtZero = true;
            this.bunifuChartCanvas1.XAxesDrawTicks = true;
            this.bunifuChartCanvas1.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.XAxesForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.bunifuChartCanvas1.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.bunifuChartCanvas1.XAxesGridLines = true;
            this.bunifuChartCanvas1.XAxesLabel = "";
            this.bunifuChartCanvas1.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.XAxesLabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.bunifuChartCanvas1.XAxesLineWidth = 1;
            this.bunifuChartCanvas1.XAxesStacked = false;
            this.bunifuChartCanvas1.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.bunifuChartCanvas1.XAxesZeroLineWidth = 1;
            this.bunifuChartCanvas1.YAxesBeginAtZero = true;
            this.bunifuChartCanvas1.YAxesDrawTicks = true;
            this.bunifuChartCanvas1.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.YAxesForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.bunifuChartCanvas1.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.bunifuChartCanvas1.YAxesGridLines = true;
            this.bunifuChartCanvas1.YAxesLabel = "";
            this.bunifuChartCanvas1.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.YAxesLabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.bunifuChartCanvas1.YAxesLineWidth = 1;
            this.bunifuChartCanvas1.YAxesStacked = false;
            this.bunifuChartCanvas1.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.bunifuChartCanvas1.YAxesZeroLineWidth = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.label5.Location = new System.Drawing.Point(246, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(355, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Quantidade de Quartos  usados ao ano";
            // 
            // LineQuartos
            // 
            this.LineQuartos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.LineQuartos.BorderCapStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.LineCaps.Butt;
            this.LineQuartos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(171)))), ((int)(((byte)(244)))));
            this.LineQuartos.BorderDash = null;
            this.LineQuartos.BorderDashOffset = 0D;
            this.LineQuartos.BorderJoin = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.BorderJoinStyles.Bevel;
            this.LineQuartos.BorderWidth = 3;
            this.LineQuartos.CubicInterpolationMode = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.CubicInterpolationModes.Default;
            this.LineQuartos.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("LineQuartos.Data")));
            this.LineQuartos.Fill = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.FillOptions.Blank;
            this.LineQuartos.Label = "Quartos Reservados";
            this.LineQuartos.LineTension = 0.4D;
            this.LineQuartos.Order = 0;
            this.LineQuartos.PointBackgroundColor = System.Drawing.Color.Empty;
            this.LineQuartos.PointBorderColor = System.Drawing.Color.Empty;
            this.LineQuartos.PointBorderWidth = 1;
            this.LineQuartos.PointHitRadius = 1;
            this.LineQuartos.PointHoverBackgroundColor = System.Drawing.Color.Empty;
            this.LineQuartos.PointHoverBorderColor = System.Drawing.Color.Empty;
            this.LineQuartos.PointHoverBorderWidth = 4;
            this.LineQuartos.PointHoverRadius = 1;
            this.LineQuartos.PointRadius = 3;
            this.LineQuartos.PointRotation = 0;
            this.LineQuartos.PointStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.PointStyles.Circle;
            this.LineQuartos.ShowLine = true;
            this.LineQuartos.SpanGaps = false;
            this.LineQuartos.SteppedLine = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.SteppedLineStyles.False;
            this.LineQuartos.TargetCanvas = this.bunifuChartCanvas1;
            // 
            // bunifuPanel4
            // 
            this.bunifuPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.bunifuPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel4.BackgroundImage")));
            this.bunifuPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel4.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel4.BorderRadius = 20;
            this.bunifuPanel4.BorderThickness = 1;
            this.bunifuPanel4.Controls.Add(this.label6);
            this.bunifuPanel4.Controls.Add(this.CircleEstoqueProgress);
            this.bunifuPanel4.Location = new System.Drawing.Point(824, 141);
            this.bunifuPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuPanel4.Name = "bunifuPanel4";
            this.bunifuPanel4.ShowBorders = true;
            this.bunifuPanel4.Size = new System.Drawing.Size(332, 408);
            this.bunifuPanel4.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.label6.Location = new System.Drawing.Point(95, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Estoque Atual";
            // 
            // CircleEstoqueProgress
            // 
            this.CircleEstoqueProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CircleEstoqueProgress.Animated = false;
            this.CircleEstoqueProgress.AnimationInterval = 1;
            this.CircleEstoqueProgress.AnimationSpeed = 1;
            this.CircleEstoqueProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.CircleEstoqueProgress.CircleMargin = 10;
            this.CircleEstoqueProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.CircleEstoqueProgress.ForeColor = System.Drawing.Color.Azure;
            this.CircleEstoqueProgress.IsPercentage = true;
            this.CircleEstoqueProgress.LineProgressThickness = 15;
            this.CircleEstoqueProgress.LineThickness = 7;
            this.CircleEstoqueProgress.Location = new System.Drawing.Point(12, 84);
            this.CircleEstoqueProgress.Margin = new System.Windows.Forms.Padding(2);
            this.CircleEstoqueProgress.Name = "CircleEstoqueProgress";
            this.CircleEstoqueProgress.ProgressAnimationSpeed = 200;
            this.CircleEstoqueProgress.ProgressBackColor = System.Drawing.Color.Azure;
            this.CircleEstoqueProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.CircleEstoqueProgress.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(171)))), ((int)(((byte)(244)))));
            this.CircleEstoqueProgress.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.CircleEstoqueProgress.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Gradient;
            this.CircleEstoqueProgress.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.CircleEstoqueProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CircleEstoqueProgress.Size = new System.Drawing.Size(308, 308);
            this.CircleEstoqueProgress.SubScriptColor = System.Drawing.Color.Azure;
            this.CircleEstoqueProgress.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.CircleEstoqueProgress.SubScriptText = "";
            this.CircleEstoqueProgress.SuperScriptColor = System.Drawing.Color.Azure;
            this.CircleEstoqueProgress.SuperScriptMargin = new System.Windows.Forms.Padding(5, 50, 0, 0);
            this.CircleEstoqueProgress.SuperScriptText = "%";
            this.CircleEstoqueProgress.TabIndex = 16;
            this.CircleEstoqueProgress.Text = "30";
            this.CircleEstoqueProgress.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.CircleEstoqueProgress.Value = 30;
            this.CircleEstoqueProgress.ValueByTransition = 30;
            this.CircleEstoqueProgress.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // bunifuPanel5
            // 
            this.bunifuPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.bunifuPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel5.BackgroundImage")));
            this.bunifuPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel5.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel5.BorderRadius = 20;
            this.bunifuPanel5.BorderThickness = 1;
            this.bunifuPanel5.Controls.Add(this.bunifuChartCanvas2);
            this.bunifuPanel5.Controls.Add(this.label7);
            this.bunifuPanel5.Location = new System.Drawing.Point(24, 555);
            this.bunifuPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuPanel5.Name = "bunifuPanel5";
            this.bunifuPanel5.ShowBorders = true;
            this.bunifuPanel5.Size = new System.Drawing.Size(791, 408);
            this.bunifuPanel5.TabIndex = 5;
            // 
            // bunifuChartCanvas2
            // 
            this.bunifuChartCanvas2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuChartCanvas2.AnimationDuration = 1000;
            this.bunifuChartCanvas2.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeInOutQuart;
            this.bunifuChartCanvas2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.bunifuChartCanvas2.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.bunifuChartCanvas2.Labels = new string[] {
        "Janeiro",
        "Feveiro",
        "Março",
        "Abril",
        "Maio",
        "Junho",
        "Julho",
        "Agosto",
        "Setembro",
        "Outubro",
        "Novembro",
        "Dezembro"};
            this.bunifuChartCanvas2.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.bunifuChartCanvas2.LegendDisplay = true;
            this.bunifuChartCanvas2.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuChartCanvas2.LegendForeColor = System.Drawing.Color.DarkGray;
            this.bunifuChartCanvas2.LegendFullWidth = true;
            this.bunifuChartCanvas2.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas2.LegendRevese = false;
            this.bunifuChartCanvas2.LegendRTL = false;
            this.bunifuChartCanvas2.Location = new System.Drawing.Point(8, 60);
            this.bunifuChartCanvas2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuChartCanvas2.Name = "bunifuChartCanvas2";
            this.bunifuChartCanvas2.ShowXAxis = true;
            this.bunifuChartCanvas2.ShowYAxis = true;
            this.bunifuChartCanvas2.Size = new System.Drawing.Size(772, 331);
            this.bunifuChartCanvas2.TabIndex = 0;
            this.bunifuChartCanvas2.Title = "";
            this.bunifuChartCanvas2.TitleLineHeight = 1D;
            this.bunifuChartCanvas2.TitlePadding = 10;
            this.bunifuChartCanvas2.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas2.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas2.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuChartCanvas2.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.bunifuChartCanvas2.TooltipsEnabled = true;
            this.bunifuChartCanvas2.XAxesBeginAtZero = true;
            this.bunifuChartCanvas2.XAxesDrawTicks = true;
            this.bunifuChartCanvas2.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.XAxesForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.bunifuChartCanvas2.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.bunifuChartCanvas2.XAxesGridLines = true;
            this.bunifuChartCanvas2.XAxesLabel = "";
            this.bunifuChartCanvas2.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.XAxesLabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.bunifuChartCanvas2.XAxesLineWidth = 1;
            this.bunifuChartCanvas2.XAxesStacked = false;
            this.bunifuChartCanvas2.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.bunifuChartCanvas2.XAxesZeroLineWidth = 1;
            this.bunifuChartCanvas2.YAxesBeginAtZero = true;
            this.bunifuChartCanvas2.YAxesDrawTicks = true;
            this.bunifuChartCanvas2.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.YAxesForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.bunifuChartCanvas2.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.bunifuChartCanvas2.YAxesGridLines = true;
            this.bunifuChartCanvas2.YAxesLabel = "";
            this.bunifuChartCanvas2.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.YAxesLabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.bunifuChartCanvas2.YAxesLineWidth = 1;
            this.bunifuChartCanvas2.YAxesStacked = false;
            this.bunifuChartCanvas2.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.bunifuChartCanvas2.YAxesZeroLineWidth = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.label7.Location = new System.Drawing.Point(340, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ganhos Mensais";
            // 
            // BarrasGanhos
            // 
            this.BarrasGanhos.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("BarrasGanhos.BackgroundColor")));
            this.BarrasGanhos.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("BarrasGanhos.BorderColor")));
            this.BarrasGanhos.BorderSkipped = null;
            this.BarrasGanhos.BorderWidth = 0;
            this.BarrasGanhos.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("BarrasGanhos.Data")));
            this.BarrasGanhos.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.BarrasGanhos.HoverBorderColor = System.Drawing.Color.Empty;
            this.BarrasGanhos.HoverBorderWidth = 0;
            this.BarrasGanhos.Label = "Label here";
            this.BarrasGanhos.TargetCanvas = this.bunifuChartCanvas2;
            // 
            // bunifuPanel6
            // 
            this.bunifuPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.bunifuPanel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel6.BackgroundImage")));
            this.bunifuPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel6.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel6.BorderRadius = 20;
            this.bunifuPanel6.BorderThickness = 1;
            this.bunifuPanel6.Controls.Add(this.label8);
            this.bunifuPanel6.Controls.Add(this.CircleQuartoProgess);
            this.bunifuPanel6.Location = new System.Drawing.Point(824, 555);
            this.bunifuPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuPanel6.Name = "bunifuPanel6";
            this.bunifuPanel6.ShowBorders = true;
            this.bunifuPanel6.Size = new System.Drawing.Size(332, 408);
            this.bunifuPanel6.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.label8.Location = new System.Drawing.Point(80, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quartos Disponiveis";
            // 
            // CircleQuartoProgess
            // 
            this.CircleQuartoProgess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CircleQuartoProgess.Animated = false;
            this.CircleQuartoProgess.AnimationInterval = 1;
            this.CircleQuartoProgess.AnimationSpeed = 1;
            this.CircleQuartoProgess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.CircleQuartoProgess.CircleMargin = 10;
            this.CircleQuartoProgess.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.CircleQuartoProgess.ForeColor = System.Drawing.Color.Azure;
            this.CircleQuartoProgess.IsPercentage = true;
            this.CircleQuartoProgess.LineProgressThickness = 15;
            this.CircleQuartoProgess.LineThickness = 7;
            this.CircleQuartoProgess.Location = new System.Drawing.Point(12, 84);
            this.CircleQuartoProgess.Margin = new System.Windows.Forms.Padding(2);
            this.CircleQuartoProgess.Name = "CircleQuartoProgess";
            this.CircleQuartoProgess.ProgressAnimationSpeed = 200;
            this.CircleQuartoProgess.ProgressBackColor = System.Drawing.Color.Azure;
            this.CircleQuartoProgess.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.CircleQuartoProgess.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(171)))), ((int)(((byte)(244)))));
            this.CircleQuartoProgess.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.CircleQuartoProgess.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Gradient;
            this.CircleQuartoProgess.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.CircleQuartoProgess.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CircleQuartoProgess.Size = new System.Drawing.Size(308, 308);
            this.CircleQuartoProgess.SubScriptColor = System.Drawing.Color.Azure;
            this.CircleQuartoProgess.SubScriptMargin = new System.Windows.Forms.Padding(5, -40, 0, 0);
            this.CircleQuartoProgess.SubScriptText = "";
            this.CircleQuartoProgess.SuperScriptColor = System.Drawing.Color.Azure;
            this.CircleQuartoProgess.SuperScriptMargin = new System.Windows.Forms.Padding(5, 50, 0, 0);
            this.CircleQuartoProgess.SuperScriptText = "%";
            this.CircleQuartoProgess.TabIndex = 16;
            this.CircleQuartoProgess.Text = "30";
            this.CircleQuartoProgess.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.CircleQuartoProgess.Value = 30;
            this.CircleQuartoProgess.ValueByTransition = 30;
            this.CircleQuartoProgess.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // PgAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.bunifuPanel6);
            this.Controls.Add(this.bunifuPanel5);
            this.Controls.Add(this.bunifuPanel4);
            this.Controls.Add(this.bunifuPanel2);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PgAnalytics";
            this.Size = new System.Drawing.Size(1169, 988);
            this.Load += new System.EventHandler(this.PgAnalytics_Load);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.bunifuPanel4.ResumeLayout(false);
            this.bunifuPanel4.PerformLayout();
            this.bunifuPanel5.ResumeLayout(false);
            this.bunifuPanel5.PerformLayout();
            this.bunifuPanel6.ResumeLayout(false);
            this.bunifuPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.Charts.WinForms.BunifuChartCanvas bunifuChartCanvas1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart LineQuartos;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuCircleProgress CircleEstoqueProgress;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel5;
        private System.Windows.Forms.Label label7;
        private Bunifu.Charts.WinForms.BunifuChartCanvas bunifuChartCanvas2;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart BarrasGanhos;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel6;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuCircleProgress CircleQuartoProgess;
    }
}
