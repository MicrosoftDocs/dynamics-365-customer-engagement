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

This topic describes how to define layout and behavior of the notification using forms.

## Prerequisites

- You must have required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)
 
## Create forms

1. Sign in to a Microsoft Dynamics 365 for Customer Engagement instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Forms** and select **+ New**.

5. In the new form, specify the details.

 | Field   | Value  |
 |---------|--------|
 | Name    | EntityNotification |
 | Order   | 10 |
 | Markup  | Copy and paste the XML content as shown below  |

```XML
  <Border xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
xmlns:CCA="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics"
xmlns:Converters="clr-namespace:USDConverters;assembly=USDConverters" xmlns:local="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics"  xmlns:System="clr-namespace:System;assembly=mscorlib" BorderThickness="1,1,1,1" CornerRadius="0" >
 <Border.Resources>
  <SolidColorBrush x:Key="BorderDefaultBrush" Color="#FF000000"/>
  <SolidColorBrush x:Key="BorderHCBrush" Color="{x:Static SystemColors.WindowTextColor}"/>
  <Style TargetType="{x:Type Border}">
   <Setter Property="BorderBrush" Value="{DynamicResource BorderDefaultBrush}" />
   <Style.Triggers>
    <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
     <Setter Property="BorderBrush" Value="{DynamicResource BorderHCBrush}"/>
    </DataTrigger>
   </Style.Triggers>
  </Style>
 </Border.Resources>
 <Grid Height="68" Width="320">
  <Grid.Resources>
   <local:CRMImageConverter x:Key="CRMImageLoader" />
   <System:String x:Key="NotificationIcon">[[NotificationIcon]+]</System:String>
   <SolidColorBrush x:Key="HCWindowTextColor" Color="{x:Static SystemColors.WindowTextColor}"/>
   <SolidColorBrush x:Key="HCBackgroundColor" Color="{x:Static SystemColors.WindowColor}" />
   <SolidColorBrush x:Key="HCHyperLinkColor" Color="{x:Static SystemColors.HotTrackColor}" />
   <Style x:Key="EntityNotificationIcon" TargetType="{x:Type Image}">
    <Setter Property="Width" Value="16" />
    <Setter Property="Height" Value="16" />
    <Setter Property="Margin" Value="14,20,14,32" />
   </Style>

   <Style x:Key="CloseIcon" TargetType="{x:Type Image}">
    <Setter Property="Width" Value="16" />
    <Setter Property="Height" Value="16" />
    <Setter Property="Margin" Value="-2" />
   </Style>

   <Style TargetType="{x:Type Grid}">
    <Setter Property="Background" Value="#003D60" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor }"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="NotificationText" TargetType="{x:Type TextBlock}">
    <Setter Property="Foreground" Value="#FFFFFF"/>
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Foreground" Value="{DynamicResource HCWindowTextColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="NotificationHyperLink" TargetType="{x:Type Hyperlink}">
    <Setter Property="Foreground" Value="#FFFFFF"/>
    <Setter Property="TextDecorations" Value="Underline" />
    <Setter Property="Cursor" Value="Hand"/>
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Foreground" Value="{DynamicResource HCHyperLinkColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
  </Grid.Resources>
  <Grid.ColumnDefinitions>
   <ColumnDefinition Width="44"/>
   <ColumnDefinition Width="246"/>
   <ColumnDefinition Width="30"/>
  </Grid.ColumnDefinitions>
  <Grid Grid.Column="0" >
   <Image Style="{StaticResource EntityNotificationIcon}" Visibility="Visible" Source="{Binding Source={StaticResource NotificationIcon}, Converter={StaticResource CRMImageLoader}}" />
  </Grid>
  <StackPanel Orientation="Vertical" Grid.Column="1" Margin="0,14">
   <TextBlock Style="{StaticResource NotificationText}" HorizontalAlignment="Left" Text="[[$Scriptlet.EntityRoutingNotification]+]" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="16" FontWeight="Regular" />
   <TextBlock >
    <Hyperlink AutomationProperties.Name="[[$Resources.ViewRecordHyperlinkText]+]" Style="{StaticResource NotificationHyperLink}" FontSize="14" FontWeight="SemiBold" Command="CCA:ActionCommands.UIIEvent" CommandParameter="CreateEntitySession?EntityLogicalName=[[EntityLogicalName]+]&amp;EntityId=[[EntityId]+]&amp;ConversationId=[[ConversationId]+]">[[$Resources.ViewRecordHyperlinkText]+]</Hyperlink>
   </TextBlock>
  </StackPanel>
  <Button Grid.Column="2" Margin="0,21,14,31" BorderThickness="0" Height="16" Width="16" Command="CCA:ActionCommands.DoActionCommand" CommandParameter="http://uii/Omni-channel Toast Notification/Close" FontWeight="SemiBold" FontFamily="Segoe UI">
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
       <Setter Property="Cursor" Value="Hand"/>
      </Trigger>
     </Style.Triggers>
    </Style>
   </Button.Style>
   <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
    <Image Grid.Column="0" Style="{StaticResource CloseIcon}"  Source="{Binding Source=new_omni_notification_close_icon, Converter={StaticResource CRMImageLoader}}" />
   </StackPanel>
  </Button>
  <Button Grid.ColumnSpan="2" Content="Test" HorizontalAlignment="Left" Margin="20,-40,0,0" VerticalAlignment="Top" Width="75"/>
 </Grid>
</Border>
```

> [!div class="nextstepaction"]
> [Next topic: Step 2: Create Omni-channel Toast Notification hosted controls](toastnotification-step2-create-hosted-controls.md)

## See also

- [Configure toast notification in Unified Service Desk](configure-toast-notification-unified-service-desk.md)
- [Step 3: Create Omni-channel Toast Notification-related action call](toastnotification-step3-create-action-call-display-notification.md)
- [Step 4: Attach Omni-channel Toast Notification-related action calls to events](toastnotification-step4-add-action-calls-events.md)
- [Step 5: Add the hosted control, events, and action calls to configurations](toastnotification-step5-add-hosted-controls-events-action-callsagent-supervisor-configurations.md)
- [Configure alert notification in Unified Service Desk](configure-alert-notification-unified-service-desk.md)
