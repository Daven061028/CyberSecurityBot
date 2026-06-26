<Window x:Class="CyberSecurityBot.LoginWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Login"
        Height="500"
        Width="800">

    <Grid Background="#0D1117">

        <Border Width="450"
                Height="400"
                Background="#161B22"
                CornerRadius="15"
                HorizontalAlignment="Center"
                VerticalAlignment="Center">

            <StackPanel Margin="20">

                <TextBlock Text="🛡 Cyber Security Login"
                           FontSize="24"
                           FontWeight="Bold"
                           Foreground="LightGreen"
                           HorizontalAlignment="Center"
                           Margin="0,0,0,20"/>

                <TextBlock Text="Username"
                           Foreground="White"/>

                <TextBox x:Name="txtUsername"
                         Height="35"
                         Margin="0,5,0,15"/>

                <TextBlock Text="Password"
                           Foreground="White"/>

                <PasswordBox x:Name="txtPassword"
                             Height="35"
                             Margin="0,5,0,15"/>

                <Button x:Name="btnLogin"
                        Content="Login"
                        Height="40"
                        Click="btnLogin_Click"/>

                <TextBlock x:Name="txtCooldown"
                           Foreground="Red"
                           FontWeight="Bold"
                           Margin="0,20,0,0"
                           TextAlignment="Center"/>

            </StackPanel>

        </Border>

    </Grid>

</Window>