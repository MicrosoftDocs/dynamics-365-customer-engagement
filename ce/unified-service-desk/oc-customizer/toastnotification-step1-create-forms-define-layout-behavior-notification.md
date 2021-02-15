---
title: "Create forms to define layout and behavior of the notification | MicrosoftDocs"
description: "Learn how to create forms to define layout and behavior of the toast notification for the Omnichannel for Customer Service agents using Unified Service Desk."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---
# Step 1: Create forms to define the layout and behavior of the notification 

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic describes how to define layout and behavior of the notification using forms.

## Prerequisites

- You must have required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)
 
## Create forms

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Forms** and select **+ New**.

5. In the new form, specify the details.

 | Field   | Value  |
 |---------|--------|
 | Name    | ToastNotification |
 | Order   | 10 |
 | Markup  | Copy and paste the XML content as shown below  |

```XML
  <Border xmlns="https://schemas.microsoft.com/winfx/2006/xaml/presentation" xmlns:x="https://schemas.microsoft.com/winfx/2006/xaml"
xmlns:CCA="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics"
xmlns:Converters="clr-namespace:USDConverters;assembly=USDConverters" xmlns:local="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics"  xmlns:System="clr-namespace:System;assembly=mscorlib" BorderThickness="1,1,1,1" CornerRadius="0" >
 <Border.Resources>
  <SolidColorBrush x:Key="BorderDefaultBrush" Color="#FF000000"/>
  <SolidColorBrush x:Key="BorderHCBrush" Color="{x:Static SystemColors.WindowFrameColor}"/>
  <Style TargetType="{x:Type Border}">
   <Setter Property="BorderBrush" Value="{DynamicResource BorderDefaultBrush}" />
   <Style.Triggers>
    <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
     <Setter Property="BorderBrush" Value="{DynamicResource BorderHCBrush}"/>
    </DataTrigger>
   </Style.Triggers>
  </Style>
 </Border.Resources>
 <Grid Height="56" Width="320">
  <Grid.Resources>
   <local:CRMImageConverter x:Key="CRMImageLoader" />
   <System:String x:Key="NotificationIcon">[[NotificationIcon]+]</System:String>

   <Style x:Key="NotificationIconStyle" TargetType="{x:Type Image}">
    <Setter Property="Width" Value="17" />
    <Setter Property="Height" Value="16" />
    <Setter Property="Margin" Value="14,17,13,23" />
   </Style>

   <Style x:Key="CloseIcon" TargetType="{x:Type Image}">
    <Setter Property="Width" Value="16" />
    <Setter Property="Height" Value="16" />
    <Setter Property="Margin" Value="-2" />
   </Style>

   <SolidColorBrush x:Key="HCWindowTextColor" Color="{x:Static SystemColors.WindowTextColor}"/>
   <SolidColorBrush x:Key="HCBackgroundColor" Color="{x:Static SystemColors.WindowColor}"/>

   <Style x:Key="NotificationTextStyle" TargetType="{x:Type TextBlock}">
    <Setter Property="Foreground" Value="#FFFFFF" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Foreground" Value="{DynamicResource HCWindowTextColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>

   <Style TargetType="{x:Type Grid}">
    <Setter Property="Background" Value="#003D60" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
  </Grid.Resources>
  <Grid.RowDefinitions>
   <RowDefinition Height="auto" />
  </Grid.RowDefinitions>
  <Grid Grid.Row="0" Height="auto" >
   <Grid.ColumnDefinitions>
    <ColumnDefinition Width="44"/>
    <ColumnDefinition Width="276"/>
   </Grid.ColumnDefinitions>

   <Grid Grid.Column="0" Height="auto" >
    <Image Style="{StaticResource NotificationIconStyle}" Visibility="Visible" Source="{Binding Source={StaticResource NotificationIcon}, Converter={StaticResource CRMImageLoader}}" />
   </Grid>

   <Grid Grid.Column="1" Height="auto" >
    <Grid.RowDefinitions>
     <RowDefinition Height="auto" />
    </Grid.RowDefinitions>
    <Grid Grid.Row="0" Height="auto" Margin="0,7,0,0">
     <Grid.ColumnDefinitions>
      <ColumnDefinition Width="239"/>
      <ColumnDefinition Width="37"/>
     </Grid.ColumnDefinitions>
     <TextBlock Style="{DynamicResource NotificationTextStyle}" Grid.Column="0" HorizontalAlignment="Left" TextWrapping="WrapWithOverflow" Text="[[ToastNotificationText]+]" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="16" FontWeight="SemiBold" />
     <Button Grid.Column="1" Margin="7,3,0,0" BorderThickness="0" Height="16" Width="16"  Command="CCA:ActionCommands.DoActionCommand" CommandParameter="https://uii/Omnichannel Toast Notification/Close" FontWeight="SemiBold" FontFamily="Segoe UI" >
      <Button.Style>
       <Style TargetType="{x:Type Button}">
        <Setter Property="Background" Value="#00FFFFFF"/>
        <Setter Property="Panel.ZIndex" Value="3"/>
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
          <Setter Property="Cursor" Value="Hand"/>
         </Trigger>
        </Style.Triggers>
       </Style>
      </Button.Style>
      <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
       <Image Grid.Column="0" Style="{StaticResource CloseIcon}"  Source="{Binding Source=new_omni_notification_close_icon, Converter={StaticResource CRMImageLoader}}" />
      </StackPanel>
     </Button>
    </Grid>
   </Grid>
  </Grid>
 </Grid>
</Border>
```

> [!div class="nextstepaction"]
> [Next topic: Step 2: Create Omnichannel Toast Notification hosted controls](toastnotification-step2-create-hosted-controls.md)

## See also

- [Configure toast notification in Unified Service Desk](configure-toast-notification-unified-service-desk.md)
- [Step 3: Create Omnichannel Toast Notification-related action call](toastnotification-step3-create-action-call-display-notification.md)
- [Step 4: Attach Omnichannel Toast Notification-related action calls to events](toastnotification-step4-add-action-calls-events.md)
- [Step 5: Add the hosted control, events, and action calls to configurations](toastnotification-step5-add-hosted-controls-events-action-callsagent-supervisor-configurations.md)
- [Configure alert notification in Unified Service Desk](configure-alert-notification-unified-service-desk.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]