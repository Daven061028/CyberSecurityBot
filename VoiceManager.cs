<Window x:Class="CyberSecurityBot.QuizWindow"
     xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
     xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
     Title="Cyber Security Quiz"
     Height="450"
     Width="800">

    
    <Grid Margin="20">

        <StackPanel>

            <TextBlock x:Name="txtQuestion"
                   FontSize="18"
                   FontWeight="Bold"
                   Margin="0,0,0,15"/>

            <ListBox x:Name="lstAnswers"
                 Height="200"
                 Margin="0,0,0,15"/>

            <Button Content="Submit Answer"
                Height="35"
                Margin="0,0,0,15"
                Click="btnSubmit_Click"/>

            <TextBlock x:Name="txtScore"
                   FontSize="16"
                   FontWeight="Bold"/>

        </StackPanel>

    </Grid>
    

</Window>
