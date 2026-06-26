<Window x:Class="CyberSecurityBot.MainWindow"
     xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
     xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
     Title="Cyber Security Awareness Chatbot"
     Height="750"
     Width="1000"
     WindowStartupLocation="CenterScreen"
     Background="#0D1117">
    
    <Grid Margin="10">

        <Grid.RowDefinitions>
            <RowDefinition Height="80"/>
            <RowDefinition Height="50"/>
            <RowDefinition Height="60"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="80"/>
        </Grid.RowDefinitions>

        <!-- HEADER -->

        <Border Grid.Row="0"
            Background="#161B22"
            CornerRadius="10"
            Padding="10">

            <Grid>

                <TextBlock Text="🛡 CYBER SECURITY AWARENESS CHATBOT"
                       Foreground="LightGreen"
                       FontSize="24"
                       FontWeight="Bold"
                       HorizontalAlignment="Center"
                       VerticalAlignment="Center"/>

                <Button x:Name="btnLogout"
                    Content="Logout"
                    Width="100"
                    Height="35"
                    HorizontalAlignment="Right"
                    VerticalAlignment="Center"
                    Margin="0,0,15,0"
                    Click="btnLogout_Click"/>

            </Grid>

        </Border>

        <!-- SECURITY LEVEL -->

        <StackPanel Grid.Row="1"
                Orientation="Horizontal"
                Margin="10,5">

            <TextBlock Text="Security Awareness Level:"
                   Foreground="White"
                   FontSize="14"
                   VerticalAlignment="Center"/>

            <ProgressBar x:Name="securityBar"
                     Width="250"
                     Height="20"
                     Margin="10,0"
                     Minimum="0"
                     Maximum="100"/>

            <TextBlock x:Name="txtLevel"
                   Text="Beginner"
                   Foreground="LightGreen"
                   FontWeight="Bold"
                   VerticalAlignment="Center"/>
        </StackPanel>

        <!-- PART 3 FEATURES -->

        <StackPanel Grid.Row="2"
                Orientation="Horizontal"
                HorizontalAlignment="Center"
                Margin="0,5">

            <Button x:Name="btnTasks"
                Content="📋 Task Manager"
                Width="150"
                Height="35"
                Margin="10"
                Click="btnTasks_Click"/>

            <Button x:Name="btnQuiz"
                Content="🎯 Cyber Quiz"
                Width="150"
                Height="35"
                Margin="10"
                Click="btnQuiz_Click"/>

            <Button x:Name="btnActivity"
                Content="📜 Activity Log"
                Width="150"
                Height="35"
                Margin="10"
                Click="btnActivity_Click"/>

        </StackPanel>

        <!-- CHAT AREA -->

        <Border Grid.Row="3"
            Background="#161B22"
            CornerRadius="10"
            Padding="10"
            Margin="0,5">

            <RichTextBox x:Name="ChatBox"
                     IsReadOnly="True"
                     BorderThickness="0"
                     Background="#161B22"
                     Foreground="White"
                     VerticalScrollBarVisibility="Auto"/>
        </Border>

        <!-- INPUT SECTION -->

        <Grid Grid.Row="4"
          Margin="0,10,0,0">

            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="120"/>
            </Grid.ColumnDefinitions>

            <TextBox x:Name="txtMessage"
                 Grid.Column="0"
                 Height="40"
                 FontSize="16"
                 VerticalContentAlignment="Center"
                 Margin="0,0,10,0"/>

            <Button x:Name="btnSend"
                Grid.Column="1"
                Height="40"
                Content="Send"
                FontSize="16"
                FontWeight="Bold"
                Click="btnSend_Click"/>

        </Grid>

    </Grid>
    

</Window>
