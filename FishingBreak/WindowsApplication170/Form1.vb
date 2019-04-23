Public Class Form1

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles PolygonCliffs.CheckedChanged
        LocationIndicator.Text = "Polygon Cliffs"
        SharkWarning.Show()
        SharkWarningLabel.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles PolygonRiver.CheckedChanged
        LocationIndicator.Text = "Polygon River"
        SharkWarning.Hide()
        SharkWarningLabel.Hide()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles PolygonLake.CheckedChanged
        LocationIndicator.Text = "Polygon Lake"
        SharkWarning.Hide()
        SharkWarningLabel.Hide()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles PolygonParadise.CheckedChanged
        LocationIndicator.Text = "Polygon Paradise Beach"
        SharkWarning.Hide()
        SharkWarningLabel.Hide()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles PolygonRocks.CheckedChanged
        LocationIndicator.Text = "Polygon Rocks"
        SharkWarning.Show()
        SharkWarningLabel.Show()
    End Sub

    Private Sub BuyLicence_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BuyLicence.LinkClicked
        If Cash.Text - 15 >= 0 Then
            Cash.Text = Cash.Text - 15
            BuyLicence.Enabled = False
            BuyLicence.Text = "Purchased"
        Else
            CantAffordLabel.Show()
        End If
    End Sub

    Private Sub BuyWoodRod_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BuyWoodRod.LinkClicked
        If BuyWoodRod.Text = "Equip" Then

            If BuyWoodRod.Text = "Equipped" Then
                BuyWoodRod.Text = "Equip"
                BuyWoodRod.Enabled = True
            End If
            If BuyPlasticRod.Text = "Equipped" Then
                BuyPlasticRod.Text = "Equip"
                BuyPlasticRod.Enabled = True
            End If
            If BuySteelRod.Text = "Equipped" Then
                BuySteelRod.Text = "Equip"
                BuySteelRod.Enabled = True
            End If
            If BuyTitanRod.Text = "Equipped" Then
                BuyTitanRod.Text = "Equip"
                BuyTitanRod.Enabled = True
            End If

            BuyWoodRod.Text = "Equipped"
            BuyWoodRod.Enabled = False

        Else
            If Cash.Text - 40 >= 0 Then

                If BuyWoodRod.Text = "Equipped" Then
                    BuyWoodRod.Text = "Equip"
                    BuyWoodRod.Enabled = True
                End If
                If BuyPlasticRod.Text = "Equipped" Then
                    BuyPlasticRod.Text = "Equip"
                    BuyPlasticRod.Enabled = True
                End If
                If BuySteelRod.Text = "Equipped" Then
                    BuySteelRod.Text = "Equip"
                    BuySteelRod.Enabled = True
                End If
                If BuyTitanRod.Text = "Equipped" Then
                    BuyTitanRod.Text = "Equip"
                    BuyTitanRod.Enabled = True
                End If

                Cash.Text = Cash.Text - 40
                BuyWoodRod.Enabled = False
                BuyWoodRod.Text = "Equipped"
            Else
                CantAffordLabel.Show()
            End If
        End If
    End Sub

    Private Sub BuyPlasticRod_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BuyPlasticRod.LinkClicked
        If BuyPlasticRod.Text = "Equip" Then
            If BuyWoodRod.Text = "Equipped" Then
                BuyWoodRod.Text = "Equip"
                BuyWoodRod.Enabled = True
            End If
            If BuyPlasticRod.Text = "Equipped" Then
                BuyPlasticRod.Text = "Equip"
                BuyPlasticRod.Enabled = True
            End If
            If BuySteelRod.Text = "Equipped" Then
                BuySteelRod.Text = "Equip"
                BuySteelRod.Enabled = True
            End If
            If BuyTitanRod.Text = "Equipped" Then
                BuyTitanRod.Text = "Equip"
                BuyTitanRod.Enabled = True
            End If

            BuyPlasticRod.Text = "Equipped"
            BuyPlasticRod.Enabled = False
        Else
            If Cash.Text - 250 >= 0 Then


                If BuyWoodRod.Text = "Equipped" Then
                    BuyWoodRod.Text = "Equip"
                    BuyWoodRod.Enabled = True
                End If
                If BuyPlasticRod.Text = "Equipped" Then
                    BuyPlasticRod.Text = "Equip"
                    BuyPlasticRod.Enabled = True
                End If
                If BuySteelRod.Text = "Equipped" Then
                    BuySteelRod.Text = "Equip"
                    BuySteelRod.Enabled = True
                End If
                If BuyTitanRod.Text = "Equipped" Then
                    BuyTitanRod.Text = "Equip"
                    BuyTitanRod.Enabled = True
                End If

                Cash.Text = Cash.Text - 250
                BuyPlasticRod.Enabled = False
                BuyPlasticRod.Text = "Equipped"
            Else
                CantAffordLabel.Show()
            End If
        End If
    End Sub

    Private Sub BuySteelRod_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BuySteelRod.LinkClicked
        If BuySteelRod.Text = "Equip" Then

            If BuyWoodRod.Text = "Equipped" Then
                BuyWoodRod.Text = "Equip"
                BuyWoodRod.Enabled = True
            End If
            If BuyPlasticRod.Text = "Equipped" Then
                BuyPlasticRod.Text = "Equip"
                BuyPlasticRod.Enabled = True
            End If
            If BuySteelRod.Text = "Equipped" Then
                BuySteelRod.Text = "Equip"
                BuySteelRod.Enabled = True
            End If
            If BuyTitanRod.Text = "Equipped" Then
                BuyTitanRod.Text = "Equip"
                BuyTitanRod.Enabled = True
            End If

            BuySteelRod.Text = "Equipped"
            BuySteelRod.Enabled = False
        Else
            If Cash.Text - 580 >= 0 Then

                If BuyWoodRod.Text = "Equipped" Then
                    BuyWoodRod.Text = "Equip"
                    BuyWoodRod.Enabled = True
                End If
                If BuyPlasticRod.Text = "Equipped" Then
                    BuyPlasticRod.Text = "Equip"
                    BuyPlasticRod.Enabled = True
                End If
                If BuySteelRod.Text = "Equipped" Then
                    BuySteelRod.Text = "Equip"
                    BuySteelRod.Enabled = True
                End If
                If BuyTitanRod.Text = "Equipped" Then
                    BuyTitanRod.Text = "Equip"
                    BuyTitanRod.Enabled = True
                End If

                Cash.Text = Cash.Text - 580
                BuySteelRod.Enabled = False
                BuySteelRod.Text = "Equipped"
            Else
                CantAffordLabel.Show()
            End If
        End If
    End Sub

    Private Sub BuyTitanRod_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BuyTitanRod.LinkClicked
        If BuyTitanRod.Text = "Equip" Then

            If BuyWoodRod.Text = "Equipped" Then
                BuyWoodRod.Text = "Equip"
                BuyWoodRod.Enabled = True
            End If
            If BuyPlasticRod.Text = "Equipped" Then
                BuyPlasticRod.Text = "Equip"
                BuyPlasticRod.Enabled = True
            End If
            If BuySteelRod.Text = "Equipped" Then
                BuySteelRod.Text = "Equip"
                BuySteelRod.Enabled = True
            End If
            If BuyTitanRod.Text = "Equipped" Then
                BuyTitanRod.Text = "Equip"
                BuyTitanRod.Enabled = True
            End If

            BuyTitanRod.Text = "Equipped"
            BuyTitanRod.Enabled = False
        Else
            If Cash.Text - 950 >= 0 Then

                If BuyWoodRod.Text = "Equipped" Then
                    BuyWoodRod.Text = "Equip"
                    BuyWoodRod.Enabled = True
                End If
                If BuyPlasticRod.Text = "Equipped" Then
                    BuyPlasticRod.Text = "Equip"
                    BuyPlasticRod.Enabled = True
                End If
                If BuySteelRod.Text = "Equipped" Then
                    BuySteelRod.Text = "Equip"
                    BuySteelRod.Enabled = True
                End If
                If BuyTitanRod.Text = "Equipped" Then
                    BuyTitanRod.Text = "Equip"
                    BuyTitanRod.Enabled = True
                End If

                Cash.Text = Cash.Text - 950
                BuyTitanRod.Enabled = False
                BuyTitanRod.Text = "Equipped"
            Else
                CantAffordLabel.Show()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rndnumber As Random
        Dim number As Integer
        rndnumber = New Random
        number = rndnumber.Next(1, 4)

        If number = 1 Then
            WeatherBox.BackgroundImage = My.Resources.sun
            WeatherLabel.Text = "Sunny"
            DescLabel.Text = "Great weather for fishing."
        End If
        If number = 2 Then
            WeatherBox.BackgroundImage = My.Resources.cloud
            WeatherLabel.Text = "Cloudy"
            DescLabel.Text = "Fair weather for fishing."
        End If
        If number = 3 Then
            WeatherBox.BackgroundImage = My.Resources.rain
            WeatherLabel.Text = "Raining"
            DescLabel.Text = "Bad weather for fishing."
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Department of Fisheries inspection rate (1 - 3) inspect number (2)
        Dim rndnumber As Random
        Dim number As Integer
        rndnumber = New Random
        number = rndnumber.Next(1, 4)

        'rate (1 - 10)
        Dim basenumber As Random
        Dim base As Integer
        basenumber = New Random
        base = basenumber.Next(1, 21)

        Dim carpRate As Integer
        Dim oysterRate As Integer
        Dim bassRate As Integer
        Dim troutRate As Integer
        Dim salmonRate As Integer
        Dim crabRate As Integer
        Dim lobsterRate As Integer
        Dim abaloneRate As Integer
        Dim sharkRate As Integer

        '------------------------------------------------
        If WeatherLabel.Text = "Sunny" Then
            If BuyWoodRod.Text = "Equipped" Then
                If PolygonCliffs.Checked = True Then
                    carpRate = 10
                    oysterRate = 3
                    bassRate = 5
                    troutRate = 6
                    salmonRate = 3
                    crabRate = 2
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonLake.Checked = True Then
                    carpRate = 5
                    oysterRate = 0
                    bassRate = 10
                    troutRate = 6
                    salmonRate = 2
                    crabRate = 1
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonParadise.Checked = True Then
                    carpRate = 0
                    oysterRate = 0
                    bassRate = 0
                    troutRate = 10
                    salmonRate = 8
                    crabRate = 0
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonRiver.Checked = True Then
                    carpRate = 20
                    oysterRate = 3
                    bassRate = 5
                    troutRate = 6
                    salmonRate = 3
                    crabRate = 2
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonRocks.Checked = True Then
                    carpRate = 5
                    oysterRate = 3
                    bassRate = 5
                    troutRate = 2
                    salmonRate = 3
                    crabRate = 10
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
            End If
            '------------------------------------------------
            If BuyPlasticRod.Text = "Equipped" Then
                If PolygonCliffs.Checked = True Then
                    carpRate = 15
                    oysterRate = 6
                    bassRate = 10
                    troutRate = 12
                    salmonRate = 6
                    crabRate = 4
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonLake.Checked = True Then
                    carpRate = 10
                    oysterRate = 0
                    bassRate = 20
                    troutRate = 12
                    salmonRate = 4
                    crabRate = 2
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonParadise.Checked = True Then
                    carpRate = 0
                    oysterRate = 0
                    bassRate = 0
                    troutRate = 20
                    salmonRate = 16
                    crabRate = 0
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonRiver.Checked = True Then
                    carpRate = 40
                    oysterRate = 6
                    bassRate = 10
                    troutRate = 12
                    salmonRate = 6
                    crabRate = 4
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonRocks.Checked = True Then
                    carpRate = 10
                    oysterRate = 6
                    bassRate = 10
                    troutRate = 4
                    salmonRate = 6
                    crabRate = 20
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
            End If
            '------------------------------------------------
            If BuySteelRod.Text = "Equipped" Then
                If PolygonCliffs.Checked = True Then
                    carpRate = 30
                    oysterRate = 12
                    bassRate = 20
                    troutRate = 24
                    salmonRate = 12
                    crabRate = 8
                    lobsterRate = 2
                    abaloneRate = 2
                    sharkRate = 1
                End If
                If PolygonLake.Checked = True Then
                    carpRate = 20
                    oysterRate = 3
                    bassRate = 40
                    troutRate = 25
                    salmonRate = 4
                    crabRate = 2
                    lobsterRate = 2
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonParadise.Checked = True Then
                    carpRate = 0
                    oysterRate = 0
                    bassRate = 0
                    troutRate = 40
                    salmonRate = 28
                    crabRate = 0
                    lobsterRate = 0
                    abaloneRate = 10
                    sharkRate = 0
                End If
                If PolygonRiver.Checked = True Then
                    carpRate = 60
                    oysterRate = 6
                    bassRate = 10
                    troutRate = 12
                    salmonRate = 6
                    crabRate = 40
                    lobsterRate = 0
                    abaloneRate = 2
                    sharkRate = 0
                End If
                If PolygonRocks.Checked = True Then
                    carpRate = 20
                    oysterRate = 12
                    bassRate = 20
                    troutRate = 8
                    salmonRate = 12
                    crabRate = 40
                    lobsterRate = 2
                    abaloneRate = 1
                    sharkRate = 2
                End If
            End If
            '------------------------------------------------
            If BuyTitanRod.Text = "Equipped" Then
                If PolygonCliffs.Checked = True Then
                    carpRate = 60
                    oysterRate = 24
                    bassRate = 40
                    troutRate = 48
                    salmonRate = 24
                    crabRate = 16
                    lobsterRate = 4
                    abaloneRate = 4
                    sharkRate = 2
                End If
                If PolygonLake.Checked = True Then
                    carpRate = 40
                    oysterRate = 6
                    bassRate = 80
                    troutRate = 50
                    salmonRate = 8
                    crabRate = 4
                    lobsterRate = 4
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonParadise.Checked = True Then
                    carpRate = 0
                    oysterRate = 0
                    bassRate = 0
                    troutRate = 80
                    salmonRate = 56
                    crabRate = 0
                    lobsterRate = 0
                    abaloneRate = 20
                    sharkRate = 0
                End If
                If PolygonRiver.Checked = True Then
                    carpRate = 120
                    oysterRate = 12
                    bassRate = 20
                    troutRate = 24
                    salmonRate = 12
                    crabRate = 80
                    lobsterRate = 0
                    abaloneRate = 4
                    sharkRate = 0
                End If
                If PolygonRocks.Checked = True Then
                    carpRate = 40
                    oysterRate = 24
                    bassRate = 40
                    troutRate = 16
                    salmonRate = 24
                    crabRate = 80
                    lobsterRate = 4
                    abaloneRate = 2
                    sharkRate = 4
                End If
            End If
        End If
        '------------------------------------------------


        If WeatherLabel.Text = "Cloudy" Then
            If BuyWoodRod.Text = "Equipped" Then
                If PolygonCliffs.Checked = True Then
                    carpRate = 8
                    oysterRate = 2
                    bassRate = 4
                    troutRate = 4
                    salmonRate = 2
                    crabRate = 1
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonLake.Checked = True Then
                    carpRate = 3
                    oysterRate = 0
                    bassRate = 8
                    troutRate = 4
                    salmonRate = 1
                    crabRate = 0
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonParadise.Checked = True Then
                    carpRate = 0
                    oysterRate = 0
                    bassRate = 0
                    troutRate = 5
                    salmonRate = 6
                    crabRate = 0
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonRiver.Checked = True Then
                    carpRate = 18
                    oysterRate = 2
                    bassRate = 4
                    troutRate = 4
                    salmonRate = 2
                    crabRate = 1
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonRocks.Checked = True Then
                    carpRate = 3
                    oysterRate = 2
                    bassRate = 3
                    troutRate = 1
                    salmonRate = 1
                    crabRate = 4
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
            End If
            '------------------------------------------------
            If BuyPlasticRod.Text = "Equipped" Then
                If PolygonCliffs.Checked = True Then
                    carpRate = 12
                    oysterRate = 4
                    bassRate = 6
                    troutRate = 8
                    salmonRate = 4
                    crabRate = 2
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonLake.Checked = True Then
                    carpRate = 7
                    oysterRate = 0
                    bassRate = 16
                    troutRate = 4
                    salmonRate = 2
                    crabRate = 1
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonParadise.Checked = True Then
                    carpRate = 0
                    oysterRate = 0
                    bassRate = 0
                    troutRate = 15
                    salmonRate = 9
                    crabRate = 0
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonRiver.Checked = True Then
                    carpRate = 20
                    oysterRate = 3
                    bassRate = 5
                    troutRate = 6
                    salmonRate = 3
                    crabRate = 2
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonRocks.Checked = True Then
                    carpRate = 5
                    oysterRate = 3
                    bassRate = 5
                    troutRate = 2
                    salmonRate = 3
                    crabRate = 2
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
            End If
            '------------------------------------------------
            If BuySteelRod.Text = "Equipped" Then
                If PolygonCliffs.Checked = True Then
                    carpRate = 25
                    oysterRate = 6
                    bassRate = 10
                    troutRate = 12
                    salmonRate = 6
                    crabRate = 6
                    lobsterRate = 1
                    abaloneRate = 1
                    sharkRate = 0
                End If
                If PolygonLake.Checked = True Then
                    carpRate = 15
                    oysterRate = 2
                    bassRate = 20
                    troutRate = 12
                    salmonRate = 2
                    crabRate = 1
                    lobsterRate = 1
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonParadise.Checked = True Then
                    carpRate = 0
                    oysterRate = 0
                    bassRate = 0
                    troutRate = 20
                    salmonRate = 12
                    crabRate = 0
                    lobsterRate = 0
                    abaloneRate = 5
                    sharkRate = 0
                End If
                If PolygonRiver.Checked = True Then
                    carpRate = 20
                    oysterRate = 3
                    bassRate = 8
                    troutRate = 8
                    salmonRate = 3
                    crabRate = 20
                    lobsterRate = 0
                    abaloneRate = 1
                    sharkRate = 0
                End If
                If PolygonRocks.Checked = True Then
                    carpRate = 15
                    oysterRate = 8
                    bassRate = 15
                    troutRate = 6
                    salmonRate = 8
                    crabRate = 34
                    lobsterRate = 1
                    abaloneRate = 0
                    sharkRate = 1
                End If
            End If
            '------------------------------------------------
            If BuyTitanRod.Text = "Equipped" Then
                If PolygonCliffs.Checked = True Then
                    carpRate = 40
                    oysterRate = 12
                    bassRate = 34
                    troutRate = 35
                    salmonRate = 20
                    crabRate = 12
                    lobsterRate = 3
                    abaloneRate = 2
                    sharkRate = 1
                End If
                If PolygonLake.Checked = True Then
                    carpRate = 32
                    oysterRate = 3
                    bassRate = 60
                    troutRate = 30
                    salmonRate = 3
                    crabRate = 2
                    lobsterRate = 2
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonParadise.Checked = True Then
                    carpRate = 0
                    oysterRate = 0
                    bassRate = 0
                    troutRate = 40
                    salmonRate = 35
                    crabRate = 0
                    lobsterRate = 0
                    abaloneRate = 14
                    sharkRate = 0
                End If
                If PolygonRiver.Checked = True Then
                    carpRate = 80
                    oysterRate = 8
                    bassRate = 12
                    troutRate = 12
                    salmonRate = 7
                    crabRate = 23
                    lobsterRate = 0
                    abaloneRate = 2
                    sharkRate = 0
                End If
                If PolygonRocks.Checked = True Then
                    carpRate = 20
                    oysterRate = 12
                    bassRate = 20
                    troutRate = 12
                    salmonRate = 12
                    crabRate = 60
                    lobsterRate = 2
                    abaloneRate = 1
                    sharkRate = 2
                End If
            End If
        End If
        '------------------------------------------------


        If WeatherLabel.Text = "Raining" Then
            If BuyWoodRod.Text = "Equipped" Then
                If PolygonCliffs.Checked = True Then
                    carpRate = 6
                    oysterRate = 1
                    bassRate = 2
                    troutRate = 1
                    salmonRate = 1
                    crabRate = 0
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonLake.Checked = True Then
                    carpRate = 2
                    oysterRate = 0
                    bassRate = 4
                    troutRate = 2
                    salmonRate = 1
                    crabRate = 0
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonParadise.Checked = True Then
                    carpRate = 0
                    oysterRate = 0
                    bassRate = 0
                    troutRate = 3
                    salmonRate = 4
                    crabRate = 0
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonRiver.Checked = True Then
                    carpRate = 12
                    oysterRate = 1
                    bassRate = 2
                    troutRate = 2
                    salmonRate = 1
                    crabRate = 0
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonRocks.Checked = True Then
                    carpRate = 1
                    oysterRate = 2
                    bassRate = 1
                    troutRate = 0
                    salmonRate = 0
                    crabRate = 2
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
            End If
            If BuyPlasticRod.Text = "Equipped" Then
                If PolygonCliffs.Checked = True Then
                    carpRate = 8
                    oysterRate = 2
                    bassRate = 4
                    troutRate = 6
                    salmonRate = 2
                    crabRate = 1
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonLake.Checked = True Then
                    carpRate = 5
                    oysterRate = 0
                    bassRate = 12
                    troutRate = 2
                    salmonRate = 1
                    crabRate = 0
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonParadise.Checked = True Then
                    carpRate = 0
                    oysterRate = 0
                    bassRate = 0
                    troutRate = 8
                    salmonRate = 3
                    crabRate = 0
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonRiver.Checked = True Then
                    carpRate = 12
                    oysterRate = 2
                    bassRate = 2
                    troutRate = 2
                    salmonRate = 1
                    crabRate = 1
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonRocks.Checked = True Then
                    carpRate = 3
                    oysterRate = 2
                    bassRate = 2
                    troutRate = 1
                    salmonRate = 2
                    crabRate = 1
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
            End If
            If BuySteelRod.Text = "Equipped" Then
                If PolygonCliffs.Checked = True Then
                    carpRate = 20
                    oysterRate = 2
                    bassRate = 8
                    troutRate = 9
                    salmonRate = 2
                    crabRate = 3
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonLake.Checked = True Then
                    carpRate = 12
                    oysterRate = 1
                    bassRate = 14
                    troutRate = 8
                    salmonRate = 1
                    crabRate = 0
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonParadise.Checked = True Then
                    carpRate = 0
                    oysterRate = 0
                    bassRate = 0
                    troutRate = 15
                    salmonRate = 8
                    crabRate = 0
                    lobsterRate = 0
                    abaloneRate = 3
                    sharkRate = 0
                End If
                If PolygonRiver.Checked = True Then
                    carpRate = 12
                    oysterRate = 2
                    bassRate = 6
                    troutRate = 6
                    salmonRate = 2
                    crabRate = 14
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonRocks.Checked = True Then
                    carpRate = 10
                    oysterRate = 6
                    bassRate = 10
                    troutRate = 3
                    salmonRate = 4
                    crabRate = 27
                    lobsterRate = 0
                    abaloneRate = 0
                    sharkRate = 0
                End If
            End If
            If BuyTitanRod.Text = "Equipped" Then
                If PolygonCliffs.Checked = True Then
                    carpRate = 30
                    oysterRate = 10
                    bassRate = 30
                    troutRate = 30
                    salmonRate = 20
                    crabRate = 10
                    lobsterRate = 2
                    abaloneRate = 1
                    sharkRate = 0
                End If
                If PolygonLake.Checked = True Then
                    carpRate = 24
                    oysterRate = 2
                    bassRate = 40
                    troutRate = 20
                    salmonRate = 2
                    crabRate = 1
                    lobsterRate = 1
                    abaloneRate = 0
                    sharkRate = 0
                End If
                If PolygonParadise.Checked = True Then
                    carpRate = 0
                    oysterRate = 0
                    bassRate = 0
                    troutRate = 32
                    salmonRate = 21
                    crabRate = 0
                    lobsterRate = 0
                    abaloneRate = 9
                    sharkRate = 0
                End If
                If PolygonRiver.Checked = True Then
                    carpRate = 60
                    oysterRate = 5
                    bassRate = 8
                    troutRate = 7
                    salmonRate = 3
                    crabRate = 16
                    lobsterRate = 0
                    abaloneRate = 1
                    sharkRate = 0
                End If
                If PolygonRocks.Checked = True Then
                    carpRate = 13
                    oysterRate = 8
                    bassRate = 12
                    troutRate = 7
                    salmonRate = 6
                    crabRate = 40
                    lobsterRate = 1
                    abaloneRate = 0
                    sharkRate = 1
                End If
            End If
        End If


        Dim carp As Random
        Dim cpfish As Integer
        carp = New Random
        cpfish = carp.Next(0, carpRate)

        Dim oyster As Random
        Dim orfish As Integer
        oyster = New Random
        orfish = oyster.Next(0, oysterRate)

        Dim bass As Random
        Dim bsfish As Integer
        bass = New Random
        bsfish = bass.Next(0, bassRate)

        Dim trout As Random
        Dim ttfish As Integer
        trout = New Random
        ttfish = trout.Next(0, troutRate)

        Dim salmon As Random
        Dim snfish As Integer
        salmon = New Random
        snfish = salmon.Next(0, salmonRate)

        Dim crab As Random
        Dim cbfish As Integer
        crab = New Random
        cbfish = crab.Next(0, crabRate)

        Dim lobster As Random
        Dim lrfish As Integer
        lobster = New Random
        lrfish = lobster.Next(0, lobsterRate)

        Dim abalone As Random
        Dim aefish As Integer
        abalone = New Random
        aefish = abalone.Next(0, abaloneRate)

        Dim shark As Random
        Dim skfish As Integer
        shark = New Random
        skfish = shark.Next(0, sharkRate)

        If BuyWoodRod.Text = "Equipped" Or BuyPlasticRod.Text = "Equipped" Or BuySteelRod.Text = "Equipped" Or BuyTitanRod.Text = "Equipped" Then
            If BuyLicence.Text = "Buy" Then

                If number = 1 Then
                    If LocationIndicator.Text = "Polygon Rocks" Or LocationIndicator.Text = "Polygon Cliffs" Then
                        If BuyWoodRod.Text = "Equipped" Or BuyPlasticRod.Text = "Equipped" Or BuySteelRod.Text = "Equipped" Or BuyTitanRod.Text = "Equipped" Then
                            MsgBox("Today you saw the Fisheries, im pretty sure i dont have a licence." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                            SCarp.Text = SCarp.Text + cpfish
                            SOyster.Text = SOyster.Text + orfish
                            SBass.Text = SBass.Text + bsfish
                            STrout.Text = STrout.Text + ttfish
                            SSalmon.Text = SSalmon.Text + snfish
                            SCrab.Text = SCrab.Text + cbfish
                            SLobster.Text = SLobster.Text + lrfish
                            SAbalone.Text = SAbalone.Text + aefish
                            SShark.Text = SShark.Text + skfish
                        End If
                    End If
                End If

                If number = 2 Then
                    If LocationIndicator.Text = "Polygon Rocks" Or LocationIndicator.Text = "Polygon Cliffs" Then
                        If BuyWoodRod.Text = "Equipped" Or BuyPlasticRod.Text = "Equipped" Or BuySteelRod.Text = "Equipped" Or BuyTitanRod.Text = "Equipped" Then
                            MsgBox("The Department of Polygon Fisheries has found you guilty of not having a fishing licence, You have been fined $80." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                            SCarp.Text = SCarp.Text + cpfish
                            SOyster.Text = SOyster.Text + orfish
                            SBass.Text = SBass.Text + bsfish
                            STrout.Text = STrout.Text + ttfish
                            SSalmon.Text = SSalmon.Text + snfish
                            SCrab.Text = SCrab.Text + cbfish
                            SLobster.Text = SLobster.Text + lrfish
                            SAbalone.Text = SAbalone.Text + aefish
                            SShark.Text = SShark.Text + skfish
                            Cash.Text = Cash.Text - 80
                        End If
                    End If
                End If

                If number = 3 Then
                    If LocationIndicator.Text = "Polygon Rocks" Or LocationIndicator.Text = "Polygon Cliffs" Then
                        If BuyWoodRod.Text = "Equipped" Or BuyPlasticRod.Text = "Equipped" Or BuySteelRod.Text = "Equipped" Or BuyTitanRod.Text = "Equipped" Then
                            MsgBox("You were able to talk your way out of a fine because you did not have a fishing licence." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                            SCarp.Text = SCarp.Text + cpfish
                            SOyster.Text = SOyster.Text + orfish
                            SBass.Text = SBass.Text + bsfish
                            STrout.Text = STrout.Text + ttfish
                            SSalmon.Text = SSalmon.Text + snfish
                            SCrab.Text = SCrab.Text + cbfish
                            SLobster.Text = SLobster.Text + lrfish
                            SAbalone.Text = SAbalone.Text + aefish
                            SShark.Text = SShark.Text + skfish
                        End If
                    End If
                End If

                If LocationIndicator.Text = "Polygon River" Or LocationIndicator.Text = "Polygon Lake" Or LocationIndicator.Text = "Polygon Paradise Beach" Then
                    MsgBox("Get a fishing licence! Good thing this area isnt patrolled by Fisheries." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                End If
            Else
                If base = 1 Then
                    MsgBox("You teached a old man on how to fish." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                    PreniumCash.Text = PreniumCash.Text + 2
                End If
                If base = 2 Then
                    MsgBox("Department of Fisheries Inspection, all of your fish were the right size." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                End If
                If base = 3 Then
                    MsgBox("Department of Fisheries Inspection, you have been found guilty of having undersized fish. Fine $20" & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                    Cash.Text = Cash.Text - 20
                End If
                If base = 4 Then
                    MsgBox("Department of Fisheries Inspection, you talked your way out of a fine because your fish were undersized." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                End If
                If base = 5 Then
                    MsgBox("Nothing much happend today..." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                End If
                If base = 6 Then
                    MsgBox("Casual day, Same catch." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                End If
                If base = 7 Then
                    MsgBox("Boring day..." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                End If
                If base = 8 Then
                    MsgBox("You got drunk with your friend and you were fined $10 for swearing at a police officer." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                    Cash.Text = Cash.Text - 10
                End If
                If base = 9 Then
                    MsgBox("You helped a swimmer who got injured." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                    PreniumCash.Text = PreniumCash.Text + 1
                End If
                If base = 10 Then
                    MsgBox("A theif has stolen your wallet..." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                    PreniumCash.Text = PreniumCash.Text - 1
                    Cash.Text = Cash.Text - 5
                End If
                If base = 12 Then
                    MsgBox("Nothing happend today..." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                End If
                If base = 13 Then
                    MsgBox("Another day out fishing..." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                End If
                If base = 14 Then
                    MsgBox("The sunset today was amazing..." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                End If
                If base = 15 Then
                    MsgBox("Saw the fisheries today..." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                End If
                If base = 16 Then
                    MsgBox("You fell into the water today and got wet, What a bad day..." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                End If
                If base = 17 Then
                    MsgBox("You went into private property but were able to talk your way out..." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                End If
                If base = 18 Then
                    MsgBox("You stayed the night and came home late..." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                End If
                If base = 19 Then
                    MsgBox("You went fishing with your childhood friend..." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                End If
                If base = 20 Then
                    MsgBox("You found a treasure chest while fishing..." & Environment.NewLine & "" & Environment.NewLine & "Today you have Catched:" & Environment.NewLine & "Carp:        x" & cpfish & Environment.NewLine & "Oyster:     x" & orfish & Environment.NewLine & "Bass:        x" & bsfish & Environment.NewLine & "Trout:      x" & ttfish & Environment.NewLine & "Salmon:  x" & snfish & Environment.NewLine & "Crab:       x" & cbfish & Environment.NewLine & "Lobster:  x" & lrfish & Environment.NewLine & "Abalone: x" & aefish & Environment.NewLine & "Shark:      x" & skfish, MsgBoxStyle.Information, Title:="End of Day")
                    SCarp.Text = SCarp.Text + cpfish
                    SOyster.Text = SOyster.Text + orfish
                    SBass.Text = SBass.Text + bsfish
                    STrout.Text = STrout.Text + ttfish
                    SSalmon.Text = SSalmon.Text + snfish
                    SCrab.Text = SCrab.Text + cbfish
                    SLobster.Text = SLobster.Text + lrfish
                    SAbalone.Text = SAbalone.Text + aefish
                    SShark.Text = SShark.Text + skfish
                    PreniumCash.Text = PreniumCash.Text + 20
                    Cash.Text = Cash.Text + 50
                End If
            End If
            BuyLicence.Enabled = True
            BuyLicence.Text = "Buy"
            Dim wrndnumber As Random
            Dim numberw As Integer
            wrndnumber = New Random
            numberw = wrndnumber.Next(1, 4)

            If numberw = 1 Then
                WeatherBox.BackgroundImage = My.Resources.sun
                WeatherLabel.Text = "Sunny"
                DescLabel.Text = "Great weather for fishing."
            End If
            If numberw = 2 Then
                WeatherBox.BackgroundImage = My.Resources.cloud
                WeatherLabel.Text = "Cloudy"
                DescLabel.Text = "Fair weather for fishing."
            End If
            If numberw = 3 Then
                WeatherBox.BackgroundImage = My.Resources.rain
                WeatherLabel.Text = "Raining"
                DescLabel.Text = "Bad weather for fishing."
            End If
        Else
            MsgBox("Uhh.. How do you go fishing without a fishing rod xD..", MsgBoxStyle.Information, Title:="Whoops..")
        End If
    End Sub

    Private Sub LCarp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LCarp.LinkClicked
        If SCarp.Text >= 1 Then
            SCarp.Text = SCarp.Text - 1
            Cash.Text = Cash.Text + 2
        End If
    End Sub

    Private Sub LOyster_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LOyster.LinkClicked
        If SOyster.Text >= 1 Then
            SOyster.Text = SOyster.Text - 1
            Cash.Text = Cash.Text + 5
        End If
    End Sub

    Private Sub LBass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LBass.LinkClicked
        If SBass.Text >= 1 Then
            SBass.Text = SBass.Text - 1
            Cash.Text = Cash.Text + 8
        End If
    End Sub

    Private Sub LTrout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LTrout.LinkClicked
        If STrout.Text >= 1 Then
            STrout.Text = STrout.Text - 1
            Cash.Text = Cash.Text + 12
        End If
    End Sub

    Private Sub LSalmon_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LSalmon.LinkClicked
        If SSalmon.Text >= 1 Then
            SSalmon.Text = SSalmon.Text - 1
            Cash.Text = Cash.Text + 18
        End If
    End Sub

    Private Sub LCrab_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LCrab.LinkClicked
        If SCrab.Text >= 1 Then
            SCrab.Text = SCrab.Text - 1
            Cash.Text = Cash.Text + 25
        End If
    End Sub

    Private Sub LLobster_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLobster.LinkClicked
        If SLobster.Text >= 1 Then
            SLobster.Text = SLobster.Text - 1
            Cash.Text = Cash.Text + 80
        End If
    End Sub

    Private Sub LAbalone_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LAbalone.LinkClicked
        If SAbalone.Text >= 1 Then
            SAbalone.Text = SAbalone.Text - 1
            Cash.Text = Cash.Text + 120
        End If
    End Sub

    Private Sub LShark_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LShark.LinkClicked
        If SShark.Text >= 1 Then
            SShark.Text = SShark.Text - 1
            Cash.Text = Cash.Text + 210
        End If
    End Sub
End Class
