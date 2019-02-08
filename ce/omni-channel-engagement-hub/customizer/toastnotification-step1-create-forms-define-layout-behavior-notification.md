---
title: "Create forms to define layout and behavior of the notification | MicrosoftDocs"
description: "Learn how to create forms to define layout and behavior of the toast notification for the Omni-channel Engagement Hub agents using Unified Service Desk."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 2/8/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 4c846869-3c6f-49ad-b6f7-a4b06f102845
ms.custom: 
---
# Step 1: Create forms to define the layout and behavior of the notification 

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

1. Sign in to Microsoft Dynamics 365 for Customer Engagement instance. 

2. Go to **Settings** > **Unified Service Desk**. 

3. Select **Forms** and select **+ New**. 

4. In the new form, specify the details. 

 | Field   | Value  |
 |---------|--------|
 | Name    | CaseEntityNotification |
 | Order   | 10 |
 | Markup  | Copy and paste the XML content as shown below  |

```XML
  <Border xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  xmlns:CCA="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics" xmlns:Converters="clr-namespace:USDConverters;assembly=USDConverters" xmlns:local="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics" xmlns:System="clr-namespace:System;assembly=mscorlib" BorderThickness="1,1,1,1" CornerRadius="2" >
    <Border.Effect>
        <DropShadowEffect/>
    </Border.Effect>
    <Border.BorderBrush>
        <SolidColorBrush Color="#333333" Opacity="0.5"/>
    </Border.BorderBrush>
    <Grid Height="96" Width="320" Background="#333333">
        <Grid.Resources>
            <local:CRMImageConverter x:Key="CRMImageLoader" />
            <Style x:Key="FOOCaseIcon" TargetType="{x:Type Image}">
                <Setter Property="Width" Value="17" />
                <Setter Property="Height" Value="16" />
                <Setter Property="Margin" Value="14,17,13,63" />
            </Style>
            <Style x:Key="CloseIcon" TargetType="{x:Type Image}">
                <Setter Property="Width" Value="16" />
                <Setter Property="Height" Value="16" />
                <Setter Property="Margin" Value="-2" />
            </Style>
        </Grid.Resources>
        <Grid.RowDefinitions>
            <RowDefinition Height="auto" />
        </Grid.RowDefinitions>
        <Button Grid.Row="0" x:Name="NotificationAcceptButton" Command="CCA:ActionCommands.UIIEvent" CommandParameter="CreateFOOEntitySession?EntityLogicalName=[[EntityLogicalName]+]&EntityId=[[EntityId]+]&ConversationId=[[ConversationId]+]" Height="96" Width="320" >
            <Button.Style>
                <Style TargetType="{x:Type Button}">
                    <Setter Property="Background" Value="#00FFFFFF"/>
                    <Setter Property="Template">
                        <Setter.Value>
                            <ControlTemplate TargetType="{x:Type Button}">
                                <Border Background="{TemplateBinding Background}">
                                    <ContentPresenter HorizontalAlignment="Center" VerticalAlignment="Center"/>
                                </Border>
                            </ControlTemplate>
                        </Setter.Value>
                    </Setter>
                    <Style.Triggers>
                        <Trigger Property="IsMouseOver" Value="True">
                            <Setter Property="Background" Value="#00FFFFFF"/>
                        </Trigger>
                    </Style.Triggers>
                </Style>
            </Button.Style>
        </Button>
        <Grid Grid.Row="0" Height="auto" >
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="44"/>
                <ColumnDefinition Width="276"/>
            </Grid.ColumnDefinitions>
            <Grid Grid.Column="0" Height="auto" >
                <Image Style="{StaticResource FOOCaseIcon}" Visibility="Visible" Source="{Binding Source=new_omni_foonotification_case_icon, Converter={StaticResource CRMImageLoader}}" />
            </Grid>
            <Grid Grid.Column="1" Height="auto" >
                <Grid.RowDefinitions>
                    <RowDefinition Height="auto" />
                </Grid.RowDefinitions>
                <Grid Grid.Row="0" Height="auto" Margin="0,14,0,0">
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="239"/>
                        <ColumnDefinition Width="37"/>
                    </Grid.ColumnDefinitions>
                    <TextBlock Foreground="#FFFFFF" Grid.Column="0" HorizontalAlignment="Left" Text="New [[EntityDisplayName]+] has been assigned" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="16" FontWeight="SemiBold" />
                    <Button Grid.Column="1" Margin="7,3,0,0" BorderThickness="0" Height="16" Width="16" Command="CCA:ActionCommands.DoActionCommand" CommandParameter="http://uii/OmniChannelToastNotification/Close" FontWeight="SemiBold" FontFamily="Segoe UI" >
                        <Button.Style>
                            <Style TargetType="{x:Type Button}">
                                <Setter Property="Background" Value="#00FFFFFF"/>
                                <Setter Property="Template">
                                    <Setter.Value><ControlTemplate TargetType="{x:Type Button}"><Border Background="{TemplateBinding Background}"><ContentPresenter HorizontalAlignment="Center" VerticalAlignment="Center"/>
                                            </Border>
                                        </ControlTemplate>
                                    </Setter.Value>
                                </Setter>
                                <Style.Triggers>
                                    <Trigger Property="IsMouseOver" Value="True">
                                        <Setter Property="Background" Value="#00FFFFFF"/>
                                    </Trigger>
                                </Style.Triggers>
                            </Style>
                        </Button.Style>
                        <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
                            <Image Grid.Column="0" Style="{StaticResource CloseIcon}" Source="{Binding Source=new_omni_notification_close_icon, Converter={StaticResource CRMImageLoader}}" />
                        </StackPanel>
                    </Button>
                </Grid>
            </Grid>
        </Grid>
    </Grid>
</Border>
```
5. Save the form.

> [!div class="nextstepaction"]
> [Next topic: Step 2: Create hosted controls](toastnotification-step2-create-hosted-controls.md)

## See also

- [Configure toast notification in Unified Service Desk](configure-toast-notification-unified-service-desk.md)
- [Step 3: Create events](toastnotification-step3-create-the-events.md)
- [Step 4: Create an action call to display the notification](toastnotification-step4-create-action-call-display-notification.md)
- [Step 5: Add the action calls to the events](toastnotification-step5-add-action-calls-events.md)
- [Step 6: Add the hosted controls, events, and action calls to the agent and supervisor configurations](toastnotification-step6-add-hosted-controls-events-action-callsagent-supervisor-configurations.md)
- [Configure alert notification in Unified Service Desk](configure-alert-notification-unified-service-desk.md)
