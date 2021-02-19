---
title: "Create forms to define the layout and behavior of the notification | MicrosoftDocs"
description: "Learn how to create forms to define layout and behavior of the alert notification in Omnichannel for Customer Service."
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

The topic describes how to define the layout and behavior of the alert notification.

## Prerequisites 

- You must have the required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

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

    | Field     | value                      |
    |-----------|----------------------------|
    | Name      | SimpleChatRequestPopupForm |
    | Order     | 10                         |
    | Markup    | Copy and paste the XML content as shown below |

 ```XML
   <Border xmlns="https://schemas.microsoft.com/winfx/2006/xaml/presentation" xmlns:x="https://schemas.microsoft.com/winfx/2006/xaml"
xmlns:CCA="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics"
xmlns:Converters="clr-namespace:USDConverters;assembly=USDConverters" xmlns:local="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics"  xmlns:System="clr-namespace:System;assembly=mscorlib" BorderThickness="1,1,1,1"
>
 <Border.Resources>
  <SolidColorBrush x:Key="BorderDefaultBrush" Color="#FFF1F1F1"/>
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

 <Grid Height="auto" Width="280" >
  <Grid.Resources>
   <System:String x:Key="switchvar">[[switchvar]+]</System:String>

   <System:String x:Key="isAccept">[[isAccept]+]</System:String>
   <System:String x:Key="isReject">[[isReject]+]</System:String>
   <System:String x:Key="designation">[[designation]+]</System:String>
   <System:String x:Key="showWarning">[[showWarning]+]</System:String>
   <System:String x:Key="jobTitle">[[jobTitle]+]</System:String>
   <System:String x:Key="email">[[email]+]</System:String>
   <System:String x:Key="city">[[city]+]</System:String>
   <System:String x:Key="state">[[state]+]</System:String>
   <System:String x:Key="EscalatedFromVirtualAgent">[[EscalatedFromVirtualAgent]+]</System:String>

   <local:CRMImageConverter x:Key="CRMImageLoader" />

   <SolidColorBrush x:Key="HCWindowTextColor" Color="{x:Static SystemColors.WindowTextColor}"/>
   <SolidColorBrush x:Key="HCBackgroundColor" Color="{x:Static SystemColors.WindowColor}"/>
   <SolidColorBrush x:Key="HCButtonBorderColor" Color="{x:Static SystemColors.HighlightColor}"/>
   <SolidColorBrush x:Key="HCWindowHighlightTextColor" Color="{x:Static SystemColors.HighlightTextColor}" />
   <SolidColorBrush x:Key="HighlightedButtonBackgroundColor" Color="{x:Static SystemColors.HighlightColor}"/>
   <SolidColorBrush x:Key="HighlightedButtonForegroundColor" Color="{x:Static SystemColors.HighlightTextColor}" />

   <Style TargetType="{x:Type Grid}">
    <Setter Property="Background" Value="#003D60" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="TimeoutStyle" TargetType="{x:Type Grid}">
    <Setter Property="Background" Value="#003D60" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="ImageLogo" TargetType="{x:Type Image}">
    <Setter Property="Width" Value="56" />
    <Setter Property="Height" Value="56" />
    <Setter Property="Margin" Value="19,4,8,8" />
   </Style>

   <Style x:Key="WarningImageLogo" TargetType="{x:Type Image}">
    <Setter Property="Width" Value="16" />
    <Setter Property="Height" Value="16" />
    <Setter Property="Margin" Value="14,17,8,52" />
   </Style>

   <Style x:Key="ButtonImage" TargetType="{x:Type Image}">
    <Setter Property="Width" Value="16" />
    <Setter Property="Height" Value="16" />
    <Setter Property="HorizontalAlignment" Value="Center" />
    <Setter Property="VerticalAlignment" Value="Center" />
   </Style>

   <Style x:Key="NotificationTimeoutBackgroundStyle" TargetType="{x:Type Grid}">
    <Setter Property="Background" Value="#032D44" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="showAutoAcceptMesage" TargetType="Grid" BasedOn="{StaticResource NotificationTimeoutBackgroundStyle}">
    <Setter Property="Visibility" Value="Collapsed"/>
    <Style.Triggers>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="FALSE" />
       <Condition Binding="{Binding Source={StaticResource isReject}}" Value="FALSE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Visible"/>
     </MultiDataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="hideAutoAcceptMesage" TargetType="Grid" BasedOn="{StaticResource NotificationTimeoutBackgroundStyle}">
    <Setter Property="Visibility" Value="Visible"/>
    <Style.Triggers>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="FALSE" />
       <Condition Binding="{Binding Source={StaticResource isReject}}" Value="FALSE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Collapsed"/>
     </MultiDataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="WarningMessageVisibilityStyle" TargetType="{x:Type Grid}">
    <Setter Property="Visibility" Value="Collapsed"/>
    <Style.Triggers>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource showWarning}}" Value="TRUE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Visible"/>
     </MultiDataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="WarningMessageBackgroundStyle" TargetType="{x:Type Grid}" BasedOn="{StaticResource WarningMessageVisibilityStyle}">
    <Setter Property="Background" Value="#003252" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="WarningMessageBorderStyle" TargetType="{x:Type Grid}" BasedOn="{StaticResource WarningMessageVisibilityStyle}">
    <Setter Property="Background" Value="#FFFFFFFF" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCWindowTextColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="AcceptButton" TargetType="{x:Type Button}">
    <Setter Property="OverridesDefaultStyle" Value="False"/>
    <Setter Property="FontSize" Value="14px"/>
    <Setter Property="BorderBrush" Value="#FFFFFFFF"/>
    <Setter Property="BorderThickness" Value="1"/>
    <Setter Property="Foreground" Value="#FFFFFF"/>
    <Setter Property="Background" >
     <Setter.Value>
      <LinearGradientBrush StartPoint="0,0" EndPoint="0,1" >
       <GradientStop Color="#008A00" Offset="0"/>
      </LinearGradientBrush>
     </Setter.Value>
    </Setter>
    <Style.Triggers>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
       <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Visible"/>
      <Setter Property="Width" Value="120" />
      <Setter Property="Margin" Value="14,7,14,14" />
     </MultiDataTrigger>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
       <Condition Binding="{Binding Source={StaticResource isReject}}" Value="FALSE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Visible"/>
      <Setter Property="Width" Value="240" />
      <Setter Property="Margin" Value="14,14,14,14" />
     </MultiDataTrigger>
     <DataTrigger Binding="{Binding Source={StaticResource isAccept}}" Value="FALSE" >
      <Setter Property="Visibility" Value="Hidden" />
     </DataTrigger>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
      <Setter Property="BorderBrush" Value="{DynamicResource HCButtonBorderColor}"/>
      <Setter Property="Foreground" Value="{DynamicResource HCWindowTextColor}"/>
     </DataTrigger>
     <Trigger Property="IsMouseOver" Value="True">
      <Setter Property="Foreground" Value="{DynamicResource HighlightedButtonForegroundColor}" />
      <Setter Property="Background" Value="{DynamicResource HighlightedButtonBackgroundColor}"/>
      <Setter Property="Cursor" Value="Hand" />
     </Trigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="RejectButton" TargetType="{x:Type Button}">
    <Setter Property="OverridesDefaultStyle" Value="False"/>
    <Setter Property="FontSize" Value="14px"/>
    <Setter Property="BorderBrush" Value="#FFFFFFFF"/>
    <Setter Property="BorderThickness" Value="1"/>
    <Setter Property="Foreground" Value="#FFFFFF"/>
    <Setter Property="Background" >
     <Setter.Value>
      <LinearGradientBrush StartPoint="0,0" EndPoint="0,1" >
       <GradientStop Color="#BF0900" Offset="0"/>
      </LinearGradientBrush>
     </Setter.Value>
    </Setter>
    <Style.Triggers>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
       <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Visible"/>
      <Setter Property="Width" Value="119" />
      <Setter Property="Margin" Value="0,7,13,14" />
     </MultiDataTrigger>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="FALSE" />
       <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Visible"/>
      <Setter Property="Width" Value="240" />
      <Setter Property="Margin" Value="14,14,14,14" />
     </MultiDataTrigger>
     <DataTrigger Binding="{Binding Source={StaticResource isReject}}" Value="FALSE" >
      <Setter Property="Visibility" Value="Hidden" />
     </DataTrigger>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
      <Setter Property="BorderBrush" Value="{DynamicResource HCButtonBorderColor}"/>
      <Setter Property="Foreground" Value="{DynamicResource HCWindowTextColor}"/>
     </DataTrigger>
     <Trigger Property="IsMouseOver" Value="True">
      <Setter Property="Foreground" Value="{DynamicResource HCWindowHighlightTextColor}" />
      <Setter Property="Background" Value="{DynamicResource HCButtonBorderColor}"/>
      <Setter Property="Cursor" Value="Hand" />
     </Trigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="BaseTextStyle" TargetType="{x:Type TextBlock}">
    <Setter Property="HorizontalAlignment" Value="Left" />
    <Setter Property="VerticalAlignment" Value="Center" />
    <Setter Property="FontSize" Value="14" />
    <Setter Property="TextTrimming" Value="WordEllipsis" />
    <Setter Property="FontFamily" Value="Segoe UI" />
    <Setter Property="LineHeight" Value="16" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Foreground" Value="{DynamicResource HCWindowTextColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="LabelTextStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource BaseTextStyle}" >
    <Setter Property="Foreground" Value="#D8D8D8"/>
    <Setter Property="Margin" Value="0,0,0,11" />
    <Setter Property="FontWeight" Value="Regular" />
   </Style>

   <Style x:Key="TextBlockStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource BaseTextStyle}" >
    <Setter Property="Foreground" Value="#FFFFFF"/>
    <Setter Property="Margin" Value="0,0,0,11" />
    <Setter Property="FontWeight" Value="SemiBold" />
    <Style.Triggers>
     <Trigger Property="Text" Value="">
      <Setter Property="Visibility" Value="Collapsed" />
     </Trigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="DefaultTextForegroundStyle" TargetType="{x:Type TextBlock}" >
    <Setter Property="Foreground" Value="#FFFFFF"/>
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Foreground" Value="{DynamicResource HCWindowTextColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="ButtonTextStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource DefaultTextForegroundStyle}">
    <Style.Triggers>
     <Trigger Property="IsMouseOver" Value="True">
      <Setter Property="Foreground" Value="{DynamicResource HCWindowHighlightTextColor}" />
     </Trigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="JobTitleLabelStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource LabelTextStyle}">
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source = {StaticResource jobTitle }}" Value="">
      <Setter Property="Visibility" Value="Collapsed"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="EmailLabelStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource LabelTextStyle}">
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source = {StaticResource email }}" Value="">
      <Setter Property="Visibility" Value="Collapsed"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="CityLabelStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource LabelTextStyle}">
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source = {StaticResource city }}" Value="">
      <Setter Property="Visibility" Value="Collapsed"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="StateLabelStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource LabelTextStyle}">
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source = {StaticResource state }}" Value="">
      <Setter Property="Visibility" Value="Collapsed"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="DesignationTextStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource DefaultTextForegroundStyle}" >
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source = {StaticResource designation }}" Value="">
      <Setter Property="Visibility" Value="Collapsed"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
  </Grid.Resources>

  <Grid.RowDefinitions>
   <RowDefinition Height="auto" />
   <RowDefinition Height="auto" />
   <RowDefinition Height="28" />
   <RowDefinition Height="86" />
   <RowDefinition Height="1" />
   <RowDefinition Height="auto" />
   <RowDefinition Height="auto" />
   <RowDefinition Height="auto" />
  </Grid.RowDefinitions>
  <!-- Max Sessions Warning Message -->
  <Grid Style="{StaticResource WarningMessageBackgroundStyle}" Grid.Row="0" Height="auto">
   <Grid.ColumnDefinitions>
    <ColumnDefinition Width="38"/>
    <ColumnDefinition Width="242"/>
   </Grid.ColumnDefinitions>
   <Image Style="{StaticResource WarningImageLogo}" Source="{Binding Source=new_omni_toast_warning_icon, Converter={StaticResource CRMImageLoader}}" Grid.Column="0" />
   <TextBlock Style="{StaticResource DefaultTextForegroundStyle}" Grid.Column="1" Margin="0,14,14,15"  HorizontalAlignment="Left" Text="[[$Resources.MaxSessionsWarningForIncomingRequest]]" FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" TextWrapping="WrapWithOverflow" FontFamily="Segoe UI"  LineHeight="19" />
  </Grid>
  <!-- Separator line -->
  <Grid Style="{StaticResource WarningMessageBorderStyle}" Grid.Row="1" Height="1" Opacity="1">
   <Grid.RowDefinitions>
    <RowDefinition Height="1" />
   </Grid.RowDefinitions>
  </Grid>

  <!-- Notification Timeout Text -->
  <Grid Style="{StaticResource showAutoAcceptMesage}" Grid.Row="2" Height="28">
   <Grid.RowDefinitions>
    <RowDefinition Height="28" />
   </Grid.RowDefinitions>
   <StackPanel Margin="14,4,14,5"  Orientation="Horizontal" VerticalAlignment="Center" Grid.Row="0">
    <TextBlock Style="{StaticResource DefaultTextForegroundStyle}" Text="[[$Resources.AutoAcceptRequestTimeoutText]] " HorizontalAlignment="Left"  FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="16" />
    <TextBlock Style="{StaticResource DefaultTextForegroundStyle}" Text="{Binding TimeoutProperty}" HorizontalAlignment="Left"  FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="16" />
    <TextBlock Style="{StaticResource DefaultTextForegroundStyle}" Text=" [[$Resources.PopupNotificationTimeoutUnit]]" HorizontalAlignment="Left"  FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="16" />
   </StackPanel>
  </Grid>

  <Grid Style="{StaticResource hideAutoAcceptMesage}" Grid.Row="2" Height="28">
   <Grid.RowDefinitions>
    <RowDefinition Height="28" />
   </Grid.RowDefinitions>
   <StackPanel Margin="14,4,14,5"  Orientation="Horizontal" VerticalAlignment="Center" Grid.Row="0">
    <TextBlock Style="{StaticResource DefaultTextForegroundStyle}" Text="{Binding TimeoutProperty}" HorizontalAlignment="Left"  FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="16" />
    <TextBlock Style="{StaticResource DefaultTextForegroundStyle}" Text=" [[$Resources.PopupNotificationTimeoutText]]" HorizontalAlignment="Left"  FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="16" />
   </StackPanel>
  </Grid>


  <!-- Chat Request From -->
  <Grid Grid.Row="3" Height="auto" >

   <Grid.ColumnDefinitions>
    <ColumnDefinition Width="83"/>
    <ColumnDefinition Width="197"/>
   </Grid.ColumnDefinitions>

   <Image Style="{StaticResource ImageLogo}" Source="[[channelIcon]+]" />

   <Grid Grid.Column="1" Margin="20,6,14,3">
    <Grid.RowDefinitions>
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
    </Grid.RowDefinitions>
    <TextBlock Grid.Row="0" Style="{StaticResource DefaultTextForegroundStyle}" HorizontalAlignment="Left" Text="[[$Scriptlet.ResolveChannelTitle]+]" FontWeight="Regular" VerticalAlignment="Center" FontSize="12" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="14" />
    <TextBlock Grid.Row="1" Style="{StaticResource DefaultTextForegroundStyle}" HorizontalAlignment="Left" FontWeight="SemiBold" Text="[[from]+]" VerticalAlignment="Center" FontSize="18" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="21"  />
    <TextBlock Grid.Row="2" Style="{StaticResource DesignationTextStyle}"  HorizontalAlignment="Left" Text="{Binding Source={StaticResource designation}}" FontWeight="Regular"  VerticalAlignment="Center" FontSize="12" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="18"  />
   </Grid>

  </Grid>
  <!-- Separator line -->
  <Grid Grid.Row="4" Height="1" Opacity="0.13" >
   <Grid.Resources>
    <Style TargetType="{x:Type Grid}" >
     <Setter Property="Background" Value="#F1F1F1" />
     <Style.Triggers>
      <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
       <Setter Property="Background" Value="{DynamicResource HCWindowTextColor}"/>
      </DataTrigger>
     </Style.Triggers>
    </Style>
   </Grid.Resources>
   <Grid.RowDefinitions>
    <RowDefinition Height="1" />
   </Grid.RowDefinitions>
  </Grid>

  <!-- Attributes-->
  <Grid Grid.Row="5" Height="auto">
   <Grid.ColumnDefinitions>
    <ColumnDefinition Width="103"/>
    <ColumnDefinition Width="177"/>
   </Grid.ColumnDefinitions>

   <Grid Grid.Column="0" Height="auto" >
    <Grid.Resources>
     <Style TargetType="{x:Type Grid}" >
      <Setter Property="Margin" Value="14,14,11,7" />
      <Style.Triggers>
       <MultiDataTrigger>
        <MultiDataTrigger.Conditions>
         <Condition Binding="{Binding Source = {StaticResource jobTitle }}" Value="" />
         <Condition Binding="{Binding Source = {StaticResource email }}" Value="" />
         <Condition Binding="{Binding Source = {StaticResource city }}" Value="" />
         <Condition Binding="{Binding Source = {StaticResource state }}" Value="" />
        </MultiDataTrigger.Conditions>
        <Setter Property="Margin" Value="0,0,0,7" />
       </MultiDataTrigger>
      </Style.Triggers>
     </Style>
    </Grid.Resources>
    <Grid.RowDefinitions>
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
    </Grid.RowDefinitions>
    <TextBlock Style="{StaticResource JobTitleLabelStyle}" Grid.Row="0" Text="[[$Resources.JobTitleLabel]]" />
    <TextBlock Style="{StaticResource EmailLabelStyle}" Grid.Row="1" Text="[[$Resources.EmailLabel]]" />
    <TextBlock Style="{StaticResource CityLabelStyle}" Grid.Row="2" Text="[[$Resources.CityLabel]]" />
    <TextBlock Style="{StaticResource StateLabelStyle}"  Grid.Row="3" Text="[[$Resources.StateLabel]]" />
   </Grid>

   <Grid Grid.Column="1" Height="auto">
    <Grid.Resources>
     <Style TargetType="{x:Type Grid}" >
      <Setter Property="Margin" Value="14,14,11,7" />
      <Style.Triggers>
       <MultiDataTrigger>
        <MultiDataTrigger.Conditions>
         <Condition Binding="{Binding Source = {StaticResource jobTitle }}" Value="" />
         <Condition Binding="{Binding Source = {StaticResource email }}" Value="" />
         <Condition Binding="{Binding Source = {StaticResource city }}" Value="" />
         <Condition Binding="{Binding Source = {StaticResource state }}" Value="" />
        </MultiDataTrigger.Conditions>
        <Setter Property="Margin" Value="0,0,0,7" />
       </MultiDataTrigger>
      </Style.Triggers>
     </Style>
    </Grid.Resources>
    <Grid.RowDefinitions>
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
    </Grid.RowDefinitions>
    <TextBlock Style="{StaticResource TextBlockStyle}" Grid.Row="0" Text="[[jobTitle]+]" />
    <TextBlock Style="{StaticResource TextBlockStyle}" Grid.Row="1" Text="[[email]+]" />
    <TextBlock Style="{StaticResource TextBlockStyle}" Grid.Row="2" Text="[[city]+]" />
    <TextBlock Style="{StaticResource TextBlockStyle}" Grid.Row="3" Text="[[state]+]" />
   </Grid>
  </Grid>
  <!-- Bot Escalation Message -->
  <Grid Grid.Row="6" Height="auto">
	<Grid.Resources>
     <Style TargetType="{x:Type Grid}" >
      <Setter Property="Margin" Value="0,0,0,7" />
	  <Setter Property="Visibility" Value="Hidden" />
      <Style.Triggers>
       <MultiDataTrigger>
        <MultiDataTrigger.Conditions>
         <Condition Binding="{Binding Source = {StaticResource EscalatedFromVirtualAgent }}" Value="True" />
        </MultiDataTrigger.Conditions>
        <Setter Property="Margin" Value="30,0,0,7" />
		<Setter Property="Visibility" Value="Visible" />
       </MultiDataTrigger>
      </Style.Triggers>
     </Style>
    </Grid.Resources>
	<Grid.RowDefinitions>
     <RowDefinition Height="auto" />
    </Grid.RowDefinitions>
	<TextBlock Style="{StaticResource TextBlockStyle}" Grid.Row="0" Text="[[$Resources.EscalatedFromVirtualAgentMessage]+]"/>
  </Grid>

  <!-- Accept / Reject Buttons -->
  <Grid Grid.Row="7" Height="auto">
   <Grid.ColumnDefinitions>
    <ColumnDefinition>
     <ColumnDefinition.Style>
      <Style TargetType="{x:Type ColumnDefinition}">
       <Setter Property="Width" Value="148" />
       <Style.Triggers>
        <DataTrigger Binding="{Binding Source={StaticResource isAccept}}" Value="FALSE" >
         <Setter Property="Width" Value="0" />
        </DataTrigger>
        <MultiDataTrigger>
         <MultiDataTrigger.Conditions>
          <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
          <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
         </MultiDataTrigger.Conditions>
         <Setter Property="Width" Value="148" />
        </MultiDataTrigger>
        <MultiDataTrigger>
         <MultiDataTrigger.Conditions>
          <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
          <Condition Binding="{Binding Source={StaticResource isReject}}" Value="FALSE" />
         </MultiDataTrigger.Conditions>
         <Setter Property="Width" Value="*" />
        </MultiDataTrigger>
       </Style.Triggers>
      </Style>
     </ColumnDefinition.Style>
    </ColumnDefinition>
    <ColumnDefinition>
     <ColumnDefinition.Style>
      <Style TargetType="{x:Type ColumnDefinition}">
       <Setter Property="Width" Value="132" />
       <Style.Triggers>
        <DataTrigger Binding="{Binding Source={StaticResource isReject}}" Value="FALSE" >
         <Setter Property="Width" Value="0" />
        </DataTrigger>
        <MultiDataTrigger>
         <MultiDataTrigger.Conditions>
          <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
          <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
         </MultiDataTrigger.Conditions>
         <Setter Property="Width" Value="132" />
        </MultiDataTrigger>
        <MultiDataTrigger>
         <MultiDataTrigger.Conditions>
          <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="FALSE" />
          <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
         </MultiDataTrigger.Conditions>
         <Setter Property="Width" Value="*" />
        </MultiDataTrigger>
       </Style.Triggers>
      </Style>
     </ColumnDefinition.Style>
    </ColumnDefinition>
   </Grid.ColumnDefinitions>

   <Button Name="btnAccept" AutomationProperties.Name="[[$Resources.AcceptButtonText]]" Grid.Column="0" Height="40" Style="{StaticResource AcceptButton}" FontWeight="SemiBold" FontFamily="Segoe UI" Command="CCA:ActionCommands.UIIEvent" CommandParameter="CreateCustomerSession?cid=[[cid]+]&amp;from=[[from]+]&amp;isUniqueContactRecognized=[[isUniqueContactRecognized]+]&amp;CRMCONTACTID=[[CRMCONTACTID]+]&amp;CanActivateSession=[[CanActivateSession]+]&amp;SessionTabId=[[SessionTabId]+]">
    <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
     <Image Grid.Column="0" Style="{StaticResource ButtonImage}"  Source="{Binding Source=new_omni_screenpop_accept_icon, Converter={StaticResource CRMImageLoader}}" />
     <TextBlock Grid.Column="1" Text="[[$Resources.AcceptButtonText]]" VerticalAlignment="Center" FontWeight="SemiBold" Margin="5,0,0,0" />
    </StackPanel>
   </Button>

   <Button Name="btnReject" AutomationProperties.Name="[[$Resources.RejectButtonText]]" Grid.Column="1" Height="40" Style="{StaticResource RejectButton}" FontWeight="SemiBold" FontFamily="Segoe UI" Command="CCA:ActionCommands.UIIEvent" CommandParameter="IncomingRequestRejected?cid=[[cid]+]&amp;from=[[from]+]" >
    <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
     <Image Grid.Column="0" Style="{StaticResource ButtonImage}"  Source="{Binding Source=new_omni_screenpop_reject_icon, Converter={StaticResource CRMImageLoader}}" />
     <TextBlock Grid.Column="1" Text="[[$Resources.RejectButtonText]]" VerticalAlignment="Center" FontWeight="SemiBold" Margin="5,0,0,0" />
    </StackPanel>
   </Button>

  </Grid>
 </Grid>
</Border>
 ```

5. Save the form.

6. Repeat steps 3 through 5 to create the following forms.

## Show conversation consult request alert notification

| Field     | value                      |
|-----------|----------------------------|
| Name      | ConsultRequestPopUpForm |
| Order     | 17                         |
| Markup    | Copy and paste the XML content as shown below |
  
```XML
<Border xmlns="https://schemas.microsoft.com/winfx/2006/xaml/presentation" xmlns:x="https://schemas.microsoft.com/winfx/2006/xaml"
xmlns:CCA="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics"
xmlns:Converters="clr-namespace:USDConverters;assembly=USDConverters" xmlns:local="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics"  xmlns:System="clr-namespace:System;assembly=mscorlib" BorderThickness="1,1,1,1"
>
 <Border.Resources>
  <SolidColorBrush x:Key="BorderDefaultBrush" Color="#FFF1F1F1"/>
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

 <Grid Height="auto" Width="280" >
  <Grid.Resources>
   <System:String x:Key="switchvar">[[switchvar]+]</System:String>

   <System:String x:Key="isAccept">[[isAccept]+]</System:String>
   <System:String x:Key="isReject">[[isReject]+]</System:String>
   <System:String x:Key="designation">[[designation]+]</System:String>
   <System:String x:Key="showWarning">[[showWarning]+]</System:String>
   <System:String x:Key="jobTitle">[[jobTitle]+]</System:String>
   <System:String x:Key="email">[[email]+]</System:String>
   <System:String x:Key="city">[[city]+]</System:String>
   <System:String x:Key="state">[[state]+]</System:String>

   <local:CRMImageConverter x:Key="CRMImageLoader" />

   <SolidColorBrush x:Key="HCWindowTextColor" Color="{x:Static SystemColors.WindowTextColor}"/>
   <SolidColorBrush x:Key="HCBackgroundColor" Color="{x:Static SystemColors.WindowColor}"/>
   <SolidColorBrush x:Key="HCButtonBorderColor" Color="{x:Static SystemColors.HighlightColor}"/>
   <SolidColorBrush x:Key="HCWindowHighlightTextColor" Color="{x:Static SystemColors.HighlightTextColor}" />
   <SolidColorBrush x:Key="HighlightedButtonBackgroundColor" Color="{x:Static SystemColors.HighlightColor}"/>
   <SolidColorBrush x:Key="HighlightedButtonForegroundColor" Color="{x:Static SystemColors.HighlightTextColor}" />

   <Style TargetType="{x:Type Grid}">
    <Setter Property="Background" Value="#003D60" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="TimeoutStyle" TargetType="{x:Type Grid}">
    <Setter Property="Background" Value="#003D60" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="ImageLogo" TargetType="{x:Type Image}">
    <Setter Property="Width" Value="56" />
    <Setter Property="Height" Value="56" />
    <Setter Property="Margin" Value="19,4,8,8" />
   </Style>

   <Style x:Key="WarningImageLogo" TargetType="{x:Type Image}">
    <Setter Property="Width" Value="16" />
    <Setter Property="Height" Value="16" />
    <Setter Property="Margin" Value="14,17,8,52" />
   </Style>

   <Style x:Key="ButtonImage" TargetType="{x:Type Image}">
    <Setter Property="Width" Value="16" />
    <Setter Property="Height" Value="16" />
    <Setter Property="HorizontalAlignment" Value="Center" />
    <Setter Property="VerticalAlignment" Value="Center" />
   </Style>
   
   <Style x:Key="headerImage" TargetType="{x:Type Image}">
    <Setter Property="Width" Value="12" />
    <Setter Property="Height" Value="12" />
    <Setter Property="HorizontalAlignment" Value="Center" />
    <Setter Property="VerticalAlignment" Value="Center" />
   </Style>
   
   <Style x:Key="NotificationTimeoutBackgroundStyle" TargetType="{x:Type Grid}">
    <Setter Property="Background" Value="#032D44" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="showAutoAcceptMesage" TargetType="Grid" BasedOn="{StaticResource NotificationTimeoutBackgroundStyle}">
    <Setter Property="Visibility" Value="Collapsed"/>
    <Style.Triggers>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="FALSE" />
       <Condition Binding="{Binding Source={StaticResource isReject}}" Value="FALSE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Visible"/>
     </MultiDataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="hideAutoAcceptMesage" TargetType="Grid" BasedOn="{StaticResource NotificationTimeoutBackgroundStyle}">
    <Setter Property="Visibility" Value="Visible"/>
    <Style.Triggers>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="FALSE" />
       <Condition Binding="{Binding Source={StaticResource isReject}}" Value="FALSE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Collapsed"/>
     </MultiDataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="WarningMessageVisibilityStyle" TargetType="{x:Type Grid}">
    <Setter Property="Visibility" Value="Collapsed"/>
    <Style.Triggers>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource showWarning}}" Value="TRUE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Visible"/>
     </MultiDataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="WarningMessageBackgroundStyle" TargetType="{x:Type Grid}" BasedOn="{StaticResource WarningMessageVisibilityStyle}">
    <Setter Property="Background" Value="#003252" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="WarningMessageBorderStyle" TargetType="{x:Type Grid}" BasedOn="{StaticResource WarningMessageVisibilityStyle}">
    <Setter Property="Background" Value="#FFFFFFFF" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCWindowTextColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="AcceptButton" TargetType="{x:Type Button}">
    <Setter Property="OverridesDefaultStyle" Value="False"/>
    <Setter Property="FontSize" Value="14px"/>
    <Setter Property="BorderBrush" Value="#FFFFFFFF"/>
    <Setter Property="BorderThickness" Value="1"/>
    <Setter Property="Foreground" Value="#FFFFFF"/>
    <Setter Property="Background" >
     <Setter.Value>
      <LinearGradientBrush StartPoint="0,0" EndPoint="0,1" >
       <GradientStop Color="#008A00" Offset="0"/>
      </LinearGradientBrush>
     </Setter.Value>
    </Setter>
    <Style.Triggers>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
       <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Visible"/>
      <Setter Property="Width" Value="120" />
      <Setter Property="Margin" Value="14,7,14,14" />
     </MultiDataTrigger>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
       <Condition Binding="{Binding Source={StaticResource isReject}}" Value="FALSE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Visible"/>
      <Setter Property="Width" Value="240" />
      <Setter Property="Margin" Value="14,14,14,14" />
     </MultiDataTrigger>
     <DataTrigger Binding="{Binding Source={StaticResource isAccept}}" Value="FALSE" >
      <Setter Property="Visibility" Value="Hidden" />
     </DataTrigger>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
      <Setter Property="BorderBrush" Value="{DynamicResource HCButtonBorderColor}"/>
      <Setter Property="Foreground" Value="{DynamicResource HCWindowTextColor}"/>
     </DataTrigger>
     <Trigger Property="IsMouseOver" Value="True">
      <Setter Property="Foreground" Value="{DynamicResource HighlightedButtonForegroundColor}" />
      <Setter Property="Background" Value="{DynamicResource HighlightedButtonBackgroundColor}"/>
      <Setter Property="Cursor" Value="Hand" />
     </Trigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="RejectButton" TargetType="{x:Type Button}">
    <Setter Property="OverridesDefaultStyle" Value="False"/>
    <Setter Property="FontSize" Value="14px"/>
    <Setter Property="BorderBrush" Value="#FFFFFFFF"/>
    <Setter Property="BorderThickness" Value="1"/>
    <Setter Property="Foreground" Value="#FFFFFF"/>
    <Setter Property="Background" >
     <Setter.Value>
      <LinearGradientBrush StartPoint="0,0" EndPoint="0,1" >
       <GradientStop Color="#BF0900" Offset="0"/>
      </LinearGradientBrush>
     </Setter.Value>
    </Setter>
    <Style.Triggers>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
       <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Visible"/>
      <Setter Property="Width" Value="119" />
      <Setter Property="Margin" Value="0,7,13,14" />
     </MultiDataTrigger>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="FALSE" />
       <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Visible"/>
      <Setter Property="Width" Value="240" />
      <Setter Property="Margin" Value="14,14,14,14" />
     </MultiDataTrigger>
     <DataTrigger Binding="{Binding Source={StaticResource isReject}}" Value="FALSE" >
      <Setter Property="Visibility" Value="Hidden" />
     </DataTrigger>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
      <Setter Property="BorderBrush" Value="{DynamicResource HCButtonBorderColor}"/>
      <Setter Property="Foreground" Value="{DynamicResource HCWindowTextColor}"/>
     </DataTrigger>
     <Trigger Property="IsMouseOver" Value="True">
      <Setter Property="Foreground" Value="{DynamicResource HCWindowHighlightTextColor}" />
      <Setter Property="Background" Value="{DynamicResource HCButtonBorderColor}"/>
      <Setter Property="Cursor" Value="Hand" />
     </Trigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="BaseTextStyle" TargetType="{x:Type TextBlock}">
    <Setter Property="HorizontalAlignment" Value="Left" />
    <Setter Property="VerticalAlignment" Value="Center" />
    <Setter Property="FontSize" Value="14" />
    <Setter Property="TextTrimming" Value="WordEllipsis" />
    <Setter Property="FontFamily" Value="Segoe UI" />
    <Setter Property="LineHeight" Value="16" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Foreground" Value="{DynamicResource HCWindowTextColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="LabelTextStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource BaseTextStyle}" >
    <Setter Property="Foreground" Value="#D8D8D8"/>
    <Setter Property="Margin" Value="0,0,0,11" />
    <Setter Property="FontWeight" Value="Regular" />
   </Style>

   <Style x:Key="TextBlockStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource BaseTextStyle}" >
    <Setter Property="Foreground" Value="#FFFFFF"/>
    <Setter Property="Margin" Value="0,0,0,11" />
    <Setter Property="FontWeight" Value="SemiBold" />
    <Style.Triggers>
     <Trigger Property="Text" Value="">
      <Setter Property="Visibility" Value="Collapsed" />
     </Trigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="DefaultTextForegroundStyle" TargetType="{x:Type TextBlock}" >
    <Setter Property="Foreground" Value="#FFFFFF"/>
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Foreground" Value="{DynamicResource HCWindowTextColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="ButtonTextStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource DefaultTextForegroundStyle}">
    <Style.Triggers>
     <Trigger Property="IsMouseOver" Value="True">
      <Setter Property="Foreground" Value="{DynamicResource HCWindowHighlightTextColor}" />
     </Trigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="JobTitleLabelStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource LabelTextStyle}">
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source = {StaticResource jobTitle }}" Value="">
      <Setter Property="Visibility" Value="Collapsed"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="EmailLabelStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource LabelTextStyle}">
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source = {StaticResource email }}" Value="">
      <Setter Property="Visibility" Value="Collapsed"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="CityLabelStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource LabelTextStyle}">
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source = {StaticResource city }}" Value="">
      <Setter Property="Visibility" Value="Collapsed"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="StateLabelStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource LabelTextStyle}">
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source = {StaticResource state }}" Value="">
      <Setter Property="Visibility" Value="Collapsed"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="DesignationTextStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource DefaultTextForegroundStyle}" >
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source = {StaticResource designation }}" Value="">
      <Setter Property="Visibility" Value="Collapsed"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
  </Grid.Resources>

  <Grid.RowDefinitions>
   <RowDefinition Height="auto" />
   <RowDefinition Height="auto" />
   <RowDefinition Height="21" />
   <RowDefinition Height="28" />
   <RowDefinition Height="86" />
   <RowDefinition Height="1" />
   <RowDefinition Height="auto" />
   <RowDefinition Height="auto" />
  </Grid.RowDefinitions>
  <!-- Max Sessions Warning Message -->
  <Grid Style="{StaticResource WarningMessageBackgroundStyle}" Grid.Row="0" Height="auto">
   <Grid.ColumnDefinitions>
    <ColumnDefinition Width="38"/>
    <ColumnDefinition Width="242"/>
   </Grid.ColumnDefinitions>
   <Image Style="{StaticResource WarningImageLogo}" Source="{Binding Source=new_omni_toast_warning_icon, Converter={StaticResource CRMImageLoader}}" Grid.Column="0" />
   <TextBlock Style="{StaticResource DefaultTextForegroundStyle}" Grid.Column="1" Margin="0,14,14,15"  HorizontalAlignment="Left" Text="[[$Resources.MaxSessionsWarningForIncomingRequest]]" FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" TextWrapping="WrapWithOverflow" FontFamily="Segoe UI"  LineHeight="19" />
  </Grid>
  <!-- Separator line -->
  <Grid Style="{StaticResource WarningMessageBorderStyle}" Grid.Row="1" Height="1" Opacity="1">
   <Grid.RowDefinitions>
    <RowDefinition Height="1" />
   </Grid.RowDefinitions>
  </Grid>

  <!-- Consult Request -->
          <Grid Grid.Row="2" Height="21">
            <Grid.Resources>
                <Style TargetType="{x:Type Grid}">
                    <Setter Property="Background" Value="#FFB22912" />
                    <Style.Triggers>
                        <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
                            <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
                        </DataTrigger>
                    </Style.Triggers>
                </Style>
            </Grid.Resources>
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="34" />
                <ColumnDefinition Width="174" />
                <ColumnDefinition Width="72" />
            </Grid.ColumnDefinitions>
            <Image Grid.Column="0" Style="{StaticResource headerImage}" Source="{Binding Source=new_omni_screenpop_transfer_icon, Converter={StaticResource CRMImageLoader}}" />
            <TextBlock Grid.Column="1" Style="{StaticResource DefaultTextForegroundStyle}" Text="[[$Resources.ConsultRequest]]" HorizontalAlignment="Left" FontWeight="SemiBold" VerticalAlignment="Center" FontSize="11" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="13" />
        </Grid>
  
  <!-- Notification Timeout Text -->
  <Grid Style="{StaticResource showAutoAcceptMesage}" Grid.Row="3" Height="28">
   <Grid.RowDefinitions>
    <RowDefinition Height="28" />
   </Grid.RowDefinitions>
   <StackPanel Margin="14,4,14,5"  Orientation="Horizontal" VerticalAlignment="Center" Grid.Row="0">
    <TextBlock Style="{StaticResource DefaultTextForegroundStyle}" Text="[[$Resources.AutoAcceptRequestTimeoutText]] " HorizontalAlignment="Left"  FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="16" />
    <TextBlock Style="{StaticResource DefaultTextForegroundStyle}" Text="{Binding TimeoutProperty}" HorizontalAlignment="Left"  FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="16" />
    <TextBlock Style="{StaticResource DefaultTextForegroundStyle}" Text=" [[$Resources.PopupNotificationTimeoutUnit]]" HorizontalAlignment="Left"  FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="16" />
   </StackPanel>
  </Grid>

  <Grid Style="{StaticResource hideAutoAcceptMesage}" Grid.Row="3" Height="28">
   <Grid.RowDefinitions>
    <RowDefinition Height="28" />
   </Grid.RowDefinitions>
   <StackPanel Margin="14,4,14,5"  Orientation="Horizontal" VerticalAlignment="Center" Grid.Row="0">
    <TextBlock Style="{StaticResource DefaultTextForegroundStyle}" Text="{Binding TimeoutProperty}" HorizontalAlignment="Left"  FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="16" />
    <TextBlock Style="{StaticResource DefaultTextForegroundStyle}" Text=" [[$Resources.PopupNotificationTimeoutText]]" HorizontalAlignment="Left"  FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="16" />
   </StackPanel>
  </Grid>


  <!-- Chat Request From -->
  <Grid Grid.Row="4" Height="auto" >

   <Grid.ColumnDefinitions>
    <ColumnDefinition Width="83"/>
    <ColumnDefinition Width="197"/>
   </Grid.ColumnDefinitions>

   <Image Style="{StaticResource ImageLogo}" Source="{Binding Source=new_omni_screenpop_incomingchat_icon, Converter={StaticResource CRMImageLoader}}" Grid.Column="0" />

   <Grid Grid.Column="1" Margin="20,6,14,3">
    <Grid.RowDefinitions>
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
    </Grid.RowDefinitions>
    <TextBlock Grid.Row="0" Style="{StaticResource DefaultTextForegroundStyle}" HorizontalAlignment="Left" Text="[[$Resources.ChatRequestTitle]]" FontWeight="Regular" VerticalAlignment="Center" FontSize="12" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="14" />
    <TextBlock Grid.Row="1" Style="{StaticResource DefaultTextForegroundStyle}" HorizontalAlignment="Left" FontWeight="SemiBold" Text="[[from]+]" VerticalAlignment="Center" FontSize="18" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="21"  />
    <TextBlock Grid.Row="2" Style="{StaticResource DesignationTextStyle}"  HorizontalAlignment="Left" Text="{Binding Source={StaticResource designation}}" FontWeight="Regular"  VerticalAlignment="Center" FontSize="12" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="18"  />
   </Grid>

  </Grid>
  <!-- Separator line -->
  <Grid Grid.Row="5" Height="1" Opacity="0.13" >
   <Grid.Resources>
    <Style TargetType="{x:Type Grid}" >
     <Setter Property="Background" Value="#F1F1F1" />
     <Style.Triggers>
      <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
       <Setter Property="Background" Value="{DynamicResource HCWindowTextColor}"/>
      </DataTrigger>
     </Style.Triggers>
    </Style>
   </Grid.Resources>
   <Grid.RowDefinitions>
    <RowDefinition Height="1" />
   </Grid.RowDefinitions>
  </Grid>

  <!-- Attributes-->
  <Grid Grid.Row="6" Height="auto">
   <Grid.ColumnDefinitions>
    <ColumnDefinition Width="103"/>
    <ColumnDefinition Width="177"/>
   </Grid.ColumnDefinitions>

   <Grid Grid.Column="0" Height="auto" >
    <Grid.Resources>
     <Style TargetType="{x:Type Grid}" >
      <Setter Property="Margin" Value="14,14,11,7" />
      <Style.Triggers>
       <MultiDataTrigger>
        <MultiDataTrigger.Conditions>
         <Condition Binding="{Binding Source = {StaticResource jobTitle }}" Value="" />
         <Condition Binding="{Binding Source = {StaticResource email }}" Value="" />
         <Condition Binding="{Binding Source = {StaticResource city }}" Value="" />
         <Condition Binding="{Binding Source = {StaticResource state }}" Value="" />
        </MultiDataTrigger.Conditions>
        <Setter Property="Margin" Value="0,0,0,7" />
       </MultiDataTrigger>
      </Style.Triggers>
     </Style>
    </Grid.Resources>
    <Grid.RowDefinitions>
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
    </Grid.RowDefinitions>
    <TextBlock Style="{StaticResource JobTitleLabelStyle}" Grid.Row="0" Text="[[$Resources.JobTitleLabel]]" />
    <TextBlock Style="{StaticResource EmailLabelStyle}" Grid.Row="1" Text="[[$Resources.EmailLabel]]" />
    <TextBlock Style="{StaticResource CityLabelStyle}" Grid.Row="2" Text="[[$Resources.CityLabel]]" />
    <TextBlock Style="{StaticResource StateLabelStyle}"  Grid.Row="3" Text="[[$Resources.StateLabel]]" />
   </Grid>

   <Grid Grid.Column="1" Height="auto">
    <Grid.Resources>
     <Style TargetType="{x:Type Grid}" >
      <Setter Property="Margin" Value="14,14,11,7" />
      <Style.Triggers>
       <MultiDataTrigger>
        <MultiDataTrigger.Conditions>
         <Condition Binding="{Binding Source = {StaticResource jobTitle }}" Value="" />
         <Condition Binding="{Binding Source = {StaticResource email }}" Value="" />
         <Condition Binding="{Binding Source = {StaticResource city }}" Value="" />
         <Condition Binding="{Binding Source = {StaticResource state }}" Value="" />
        </MultiDataTrigger.Conditions>
        <Setter Property="Margin" Value="0,0,0,7" />
       </MultiDataTrigger>
      </Style.Triggers>
     </Style>
    </Grid.Resources>
    <Grid.RowDefinitions>
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
    </Grid.RowDefinitions>
    <TextBlock Style="{StaticResource TextBlockStyle}" Grid.Row="0" Text="[[jobTitle]+]" />
    <TextBlock Style="{StaticResource TextBlockStyle}" Grid.Row="1" Text="[[email]+]" />
    <TextBlock Style="{StaticResource TextBlockStyle}" Grid.Row="2" Text="[[city]+]" />
    <TextBlock Style="{StaticResource TextBlockStyle}" Grid.Row="3" Text="[[state]+]" />
   </Grid>
  </Grid>

  <!-- Accept / Reject Buttons -->
  <Grid Grid.Row="7" Height="auto">
   <Grid.ColumnDefinitions>
    <ColumnDefinition>
     <ColumnDefinition.Style>
      <Style TargetType="{x:Type ColumnDefinition}">
       <Setter Property="Width" Value="148" />
       <Style.Triggers>
        <DataTrigger Binding="{Binding Source={StaticResource isAccept}}" Value="FALSE" >
         <Setter Property="Width" Value="0" />
        </DataTrigger>
        <MultiDataTrigger>
         <MultiDataTrigger.Conditions>
          <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
          <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
         </MultiDataTrigger.Conditions>
         <Setter Property="Width" Value="148" />
        </MultiDataTrigger>
        <MultiDataTrigger>
         <MultiDataTrigger.Conditions>
          <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
          <Condition Binding="{Binding Source={StaticResource isReject}}" Value="FALSE" />
         </MultiDataTrigger.Conditions>
         <Setter Property="Width" Value="*" />
        </MultiDataTrigger>
       </Style.Triggers>
      </Style>
     </ColumnDefinition.Style>
    </ColumnDefinition>
    <ColumnDefinition>
     <ColumnDefinition.Style>
      <Style TargetType="{x:Type ColumnDefinition}">
       <Setter Property="Width" Value="132" />
       <Style.Triggers>
        <DataTrigger Binding="{Binding Source={StaticResource isReject}}" Value="FALSE" >
         <Setter Property="Width" Value="0" />
        </DataTrigger>
        <MultiDataTrigger>
         <MultiDataTrigger.Conditions>
          <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
          <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
         </MultiDataTrigger.Conditions>
         <Setter Property="Width" Value="132" />
        </MultiDataTrigger>
        <MultiDataTrigger>
         <MultiDataTrigger.Conditions>
          <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="FALSE" />
          <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
         </MultiDataTrigger.Conditions>
         <Setter Property="Width" Value="*" />
        </MultiDataTrigger>
       </Style.Triggers>
      </Style>
     </ColumnDefinition.Style>
    </ColumnDefinition>
   </Grid.ColumnDefinitions>

   <Button Name="btnAccept" AutomationProperties.Name="[[$Resources.AcceptButtonText]]" Grid.Column="0" Height="40" Style="{StaticResource AcceptButton}" FontWeight="SemiBold" FontFamily="Segoe UI" Command="CCA:ActionCommands.UIIEvent" CommandParameter="CreateCustomerSession?cid=[[cid]+]&amp;from=[[from]+]&amp;isUniqueContactRecognized=[[isUniqueContactRecognized]+]&amp;CRMCONTACTID=[[CRMCONTACTID]+]&amp;CanActivateSession=[[CanActivateSession]+]&amp;SessionTabId=[[SessionTabId]+]">
    <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
     <Image Grid.Column="0" Style="{StaticResource ButtonImage}"  Source="{Binding Source=new_omni_screenpop_accept_icon, Converter={StaticResource CRMImageLoader}}" />
     <TextBlock Grid.Column="1" Text="[[$Resources.AcceptButtonText]]" VerticalAlignment="Center" FontWeight="SemiBold" Margin="5,0,0,0" />
    </StackPanel>
   </Button>

   <Button Name="btnReject" AutomationProperties.Name="[[$Resources.RejectButtonText]]" Grid.Column="1" Height="40" Style="{StaticResource RejectButton}" FontWeight="SemiBold" FontFamily="Segoe UI" Command="CCA:ActionCommands.UIIEvent" CommandParameter="IncomingRequestRejected?cid=[[cid]+]&amp;from=[[from]+]" >
    <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
     <Image Grid.Column="0" Style="{StaticResource ButtonImage}"  Source="{Binding Source=new_omni_screenpop_reject_icon, Converter={StaticResource CRMImageLoader}}" />
     <TextBlock Grid.Column="1" Text="[[$Resources.RejectButtonText]]" VerticalAlignment="Center" FontWeight="SemiBold" Margin="5,0,0,0" />
    </StackPanel>
   </Button>

  </Grid>
 </Grid>
</Border>
```

## Show conversation transfer request alert notification

| Field     | value                      |
|-----------|----------------------------|
| Name      | ChatTransferRequestPopUpForm |
| Order     | 20                         |
| Markup    | Copy and paste the XML content as shown below |
  
```XML
<Border xmlns="https://schemas.microsoft.com/winfx/2006/xaml/presentation" xmlns:x="https://schemas.microsoft.com/winfx/2006/xaml"
xmlns:CCA="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics"
xmlns:Converters="clr-namespace:USDConverters;assembly=USDConverters" xmlns:local="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics"  xmlns:System="clr-namespace:System;assembly=mscorlib" BorderThickness="1,1,1,1"
>
 <Border.Resources>
  <SolidColorBrush x:Key="BorderDefaultBrush" Color="#FFF1F1F1"/>
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

 <Grid Height="auto" Width="280" >
  <Grid.Resources>
   <System:String x:Key="switchvar">[[switchvar]+]</System:String>

   <System:String x:Key="isAccept">[[isAccept]+]</System:String>
   <System:String x:Key="isReject">[[isReject]+]</System:String>
   <System:String x:Key="designation">[[designation]+]</System:String>
   <System:String x:Key="showWarning">[[showWarning]+]</System:String>
   <System:String x:Key="jobTitle">[[jobTitle]+]</System:String>
   <System:String x:Key="email">[[email]+]</System:String>
   <System:String x:Key="city">[[city]+]</System:String>
   <System:String x:Key="state">[[state]+]</System:String>

   <local:CRMImageConverter x:Key="CRMImageLoader" />

   <SolidColorBrush x:Key="HCWindowTextColor" Color="{x:Static SystemColors.WindowTextColor}"/>
   <SolidColorBrush x:Key="HCBackgroundColor" Color="{x:Static SystemColors.WindowColor}"/>
   <SolidColorBrush x:Key="HCButtonBorderColor" Color="{x:Static SystemColors.HighlightColor}"/>
   <SolidColorBrush x:Key="HCWindowHighlightTextColor" Color="{x:Static SystemColors.HighlightTextColor}" />
   <SolidColorBrush x:Key="HighlightedButtonBackgroundColor" Color="{x:Static SystemColors.HighlightColor}"/>
   <SolidColorBrush x:Key="HighlightedButtonForegroundColor" Color="{x:Static SystemColors.HighlightTextColor}" />

   <Style TargetType="{x:Type Grid}">
    <Setter Property="Background" Value="#003D60" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="TimeoutStyle" TargetType="{x:Type Grid}">
    <Setter Property="Background" Value="#003D60" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="ImageLogo" TargetType="{x:Type Image}">
    <Setter Property="Width" Value="56" />
    <Setter Property="Height" Value="56" />
    <Setter Property="Margin" Value="19,4,8,8" />
   </Style>

   <Style x:Key="WarningImageLogo" TargetType="{x:Type Image}">
    <Setter Property="Width" Value="16" />
    <Setter Property="Height" Value="16" />
    <Setter Property="Margin" Value="14,17,8,52" />
   </Style>

   <Style x:Key="ButtonImage" TargetType="{x:Type Image}">
    <Setter Property="Width" Value="16" />
    <Setter Property="Height" Value="16" />
    <Setter Property="HorizontalAlignment" Value="Center" />
    <Setter Property="VerticalAlignment" Value="Center" />
   </Style>
   
   <Style x:Key="headerImage" TargetType="{x:Type Image}">
    <Setter Property="Width" Value="12" />
    <Setter Property="Height" Value="12" />
    <Setter Property="HorizontalAlignment" Value="Center" />
    <Setter Property="VerticalAlignment" Value="Center" />
   </Style>
   
   <Style x:Key="NotificationTimeoutBackgroundStyle" TargetType="{x:Type Grid}">
    <Setter Property="Background" Value="#032D44" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="showAutoAcceptMesage" TargetType="Grid" BasedOn="{StaticResource NotificationTimeoutBackgroundStyle}">
    <Setter Property="Visibility" Value="Collapsed"/>
    <Style.Triggers>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="FALSE" />
       <Condition Binding="{Binding Source={StaticResource isReject}}" Value="FALSE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Visible"/>
     </MultiDataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="hideAutoAcceptMesage" TargetType="Grid" BasedOn="{StaticResource NotificationTimeoutBackgroundStyle}">
    <Setter Property="Visibility" Value="Visible"/>
    <Style.Triggers>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="FALSE" />
       <Condition Binding="{Binding Source={StaticResource isReject}}" Value="FALSE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Collapsed"/>
     </MultiDataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="WarningMessageVisibilityStyle" TargetType="{x:Type Grid}">
    <Setter Property="Visibility" Value="Collapsed"/>
    <Style.Triggers>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource showWarning}}" Value="TRUE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Visible"/>
     </MultiDataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="WarningMessageBackgroundStyle" TargetType="{x:Type Grid}" BasedOn="{StaticResource WarningMessageVisibilityStyle}">
    <Setter Property="Background" Value="#003252" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="WarningMessageBorderStyle" TargetType="{x:Type Grid}" BasedOn="{StaticResource WarningMessageVisibilityStyle}">
    <Setter Property="Background" Value="#FFFFFFFF" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCWindowTextColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="AcceptButton" TargetType="{x:Type Button}">
    <Setter Property="OverridesDefaultStyle" Value="False"/>
    <Setter Property="FontSize" Value="14px"/>
    <Setter Property="BorderBrush" Value="#FFFFFFFF"/>
    <Setter Property="BorderThickness" Value="1"/>
    <Setter Property="Foreground" Value="#FFFFFF"/>
    <Setter Property="Background" >
     <Setter.Value>
      <LinearGradientBrush StartPoint="0,0" EndPoint="0,1" >
       <GradientStop Color="#008A00" Offset="0"/>
      </LinearGradientBrush>
     </Setter.Value>
    </Setter>
    <Style.Triggers>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
       <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Visible"/>
      <Setter Property="Width" Value="120" />
      <Setter Property="Margin" Value="14,7,14,14" />
     </MultiDataTrigger>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
       <Condition Binding="{Binding Source={StaticResource isReject}}" Value="FALSE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Visible"/>
      <Setter Property="Width" Value="240" />
      <Setter Property="Margin" Value="14,14,14,14" />
     </MultiDataTrigger>
     <DataTrigger Binding="{Binding Source={StaticResource isAccept}}" Value="FALSE" >
      <Setter Property="Visibility" Value="Hidden" />
     </DataTrigger>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
      <Setter Property="BorderBrush" Value="{DynamicResource HCButtonBorderColor}"/>
      <Setter Property="Foreground" Value="{DynamicResource HCWindowTextColor}"/>
     </DataTrigger>
     <Trigger Property="IsMouseOver" Value="True">
      <Setter Property="Foreground" Value="{DynamicResource HighlightedButtonForegroundColor}" />
      <Setter Property="Background" Value="{DynamicResource HighlightedButtonBackgroundColor}"/>
      <Setter Property="Cursor" Value="Hand" />
     </Trigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="RejectButton" TargetType="{x:Type Button}">
    <Setter Property="OverridesDefaultStyle" Value="False"/>
    <Setter Property="FontSize" Value="14px"/>
    <Setter Property="BorderBrush" Value="#FFFFFFFF"/>
    <Setter Property="BorderThickness" Value="1"/>
    <Setter Property="Foreground" Value="#FFFFFF"/>
    <Setter Property="Background" >
     <Setter.Value>
      <LinearGradientBrush StartPoint="0,0" EndPoint="0,1" >
       <GradientStop Color="#BF0900" Offset="0"/>
      </LinearGradientBrush>
     </Setter.Value>
    </Setter>
    <Style.Triggers>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
       <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Visible"/>
      <Setter Property="Width" Value="119" />
      <Setter Property="Margin" Value="0,7,13,14" />
     </MultiDataTrigger>
     <MultiDataTrigger>
      <MultiDataTrigger.Conditions>
       <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="FALSE" />
       <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
      </MultiDataTrigger.Conditions>
      <Setter Property="Visibility" Value="Visible"/>
      <Setter Property="Width" Value="240" />
      <Setter Property="Margin" Value="14,14,14,14" />
     </MultiDataTrigger>
     <DataTrigger Binding="{Binding Source={StaticResource isReject}}" Value="FALSE" >
      <Setter Property="Visibility" Value="Hidden" />
     </DataTrigger>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
      <Setter Property="BorderBrush" Value="{DynamicResource HCButtonBorderColor}"/>
      <Setter Property="Foreground" Value="{DynamicResource HCWindowTextColor}"/>
     </DataTrigger>
     <Trigger Property="IsMouseOver" Value="True">
      <Setter Property="Foreground" Value="{DynamicResource HCWindowHighlightTextColor}" />
      <Setter Property="Background" Value="{DynamicResource HCButtonBorderColor}"/>
      <Setter Property="Cursor" Value="Hand" />
     </Trigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="BaseTextStyle" TargetType="{x:Type TextBlock}">
    <Setter Property="HorizontalAlignment" Value="Left" />
    <Setter Property="VerticalAlignment" Value="Center" />
    <Setter Property="FontSize" Value="14" />
    <Setter Property="TextTrimming" Value="WordEllipsis" />
    <Setter Property="FontFamily" Value="Segoe UI" />
    <Setter Property="LineHeight" Value="16" />
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Foreground" Value="{DynamicResource HCWindowTextColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="LabelTextStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource BaseTextStyle}" >
    <Setter Property="Foreground" Value="#D8D8D8"/>
    <Setter Property="Margin" Value="0,0,0,11" />
    <Setter Property="FontWeight" Value="Regular" />
   </Style>

   <Style x:Key="TextBlockStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource BaseTextStyle}" >
    <Setter Property="Foreground" Value="#FFFFFF"/>
    <Setter Property="Margin" Value="0,0,0,11" />
    <Setter Property="FontWeight" Value="SemiBold" />
    <Style.Triggers>
     <Trigger Property="Text" Value="">
      <Setter Property="Visibility" Value="Collapsed" />
     </Trigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="DefaultTextForegroundStyle" TargetType="{x:Type TextBlock}" >
    <Setter Property="Foreground" Value="#FFFFFF"/>
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
      <Setter Property="Foreground" Value="{DynamicResource HCWindowTextColor}"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="ButtonTextStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource DefaultTextForegroundStyle}">
    <Style.Triggers>
     <Trigger Property="IsMouseOver" Value="True">
      <Setter Property="Foreground" Value="{DynamicResource HCWindowHighlightTextColor}" />
     </Trigger>
    </Style.Triggers>
   </Style>

   <Style x:Key="JobTitleLabelStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource LabelTextStyle}">
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source = {StaticResource jobTitle }}" Value="">
      <Setter Property="Visibility" Value="Collapsed"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="EmailLabelStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource LabelTextStyle}">
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source = {StaticResource email }}" Value="">
      <Setter Property="Visibility" Value="Collapsed"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="CityLabelStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource LabelTextStyle}">
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source = {StaticResource city }}" Value="">
      <Setter Property="Visibility" Value="Collapsed"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="StateLabelStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource LabelTextStyle}">
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source = {StaticResource state }}" Value="">
      <Setter Property="Visibility" Value="Collapsed"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
   <Style x:Key="DesignationTextStyle" TargetType="{x:Type TextBlock}" BasedOn="{StaticResource DefaultTextForegroundStyle}" >
    <Style.Triggers>
     <DataTrigger Binding="{Binding Source = {StaticResource designation }}" Value="">
      <Setter Property="Visibility" Value="Collapsed"/>
     </DataTrigger>
    </Style.Triggers>
   </Style>
  </Grid.Resources>

  <Grid.RowDefinitions>
   <RowDefinition Height="auto" />
   <RowDefinition Height="auto" />
   <RowDefinition Height="21" />
   <RowDefinition Height="28" />
   <RowDefinition Height="86" />
   <RowDefinition Height="1" />
   <RowDefinition Height="auto" />
   <RowDefinition Height="auto" />
  </Grid.RowDefinitions>
  <!-- Max Sessions Warning Message -->
  <Grid Style="{StaticResource WarningMessageBackgroundStyle}" Grid.Row="0" Height="auto">
   <Grid.ColumnDefinitions>
    <ColumnDefinition Width="38"/>
    <ColumnDefinition Width="242"/>
   </Grid.ColumnDefinitions>
   <Image Style="{StaticResource WarningImageLogo}" Source="{Binding Source=new_omni_toast_warning_icon, Converter={StaticResource CRMImageLoader}}" Grid.Column="0" />
   <TextBlock Style="{StaticResource DefaultTextForegroundStyle}" Grid.Column="1" Margin="0,14,14,15"  HorizontalAlignment="Left" Text="[[$Resources.MaxSessionsWarningForIncomingRequest]]" FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" TextWrapping="WrapWithOverflow" FontFamily="Segoe UI"  LineHeight="19" />
  </Grid>
  <!-- Separator line -->
  <Grid Style="{StaticResource WarningMessageBorderStyle}" Grid.Row="1" Height="1" Opacity="1">
   <Grid.RowDefinitions>
    <RowDefinition Height="1" />
   </Grid.RowDefinitions>
  </Grid>

  <!-- Transfer Request -->
          <Grid Grid.Row="2" Height="21">
            <Grid.Resources>
                <Style TargetType="{x:Type Grid}">
                    <Setter Property="Background" Value="#000000" />
                    <Style.Triggers>
                        <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
                            <Setter Property="Background" Value="{DynamicResource HCBackgroundColor}"/>
                        </DataTrigger>
                    </Style.Triggers>
                </Style>
            </Grid.Resources>
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="34" />
                <ColumnDefinition Width="174" />
                <ColumnDefinition Width="72" />
            </Grid.ColumnDefinitions>
            <Image Grid.Column="0" Style="{StaticResource headerImage}" Source="{Binding Source=new_omni_screenpop_transfer_icon, Converter={StaticResource CRMImageLoader}}" />
            <TextBlock Grid.Column="1" Style="{StaticResource DefaultTextForegroundStyle}" Text="[[$Resources.TransferRequest]]" HorizontalAlignment="Left" FontWeight="SemiBold" VerticalAlignment="Center" FontSize="11" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="13" />
        </Grid>
  
  <!-- Notification Timeout Text -->
  <Grid Style="{StaticResource showAutoAcceptMesage}" Grid.Row="3" Height="28">
   <Grid.RowDefinitions>
    <RowDefinition Height="28" />
   </Grid.RowDefinitions>
   <StackPanel Margin="14,4,14,5"  Orientation="Horizontal" VerticalAlignment="Center" Grid.Row="0">
    <TextBlock Style="{StaticResource DefaultTextForegroundStyle}" Text="[[$Resources.AutoAcceptRequestTimeoutText]] " HorizontalAlignment="Left"  FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="16" />
    <TextBlock Style="{StaticResource DefaultTextForegroundStyle}" Text="{Binding TimeoutProperty}" HorizontalAlignment="Left"  FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="16" />
    <TextBlock Style="{StaticResource DefaultTextForegroundStyle}" Text=" [[$Resources.PopupNotificationTimeoutUnit]]" HorizontalAlignment="Left"  FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="16" />
   </StackPanel>
  </Grid>

  <Grid Style="{StaticResource hideAutoAcceptMesage}" Grid.Row="3" Height="28">
   <Grid.RowDefinitions>
    <RowDefinition Height="28" />
   </Grid.RowDefinitions>
   <StackPanel Margin="14,4,14,5"  Orientation="Horizontal" VerticalAlignment="Center" Grid.Row="0">
    <TextBlock Style="{StaticResource DefaultTextForegroundStyle}" Text="{Binding TimeoutProperty}" HorizontalAlignment="Left"  FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="16" />
    <TextBlock Style="{StaticResource DefaultTextForegroundStyle}" Text=" [[$Resources.PopupNotificationTimeoutText]]" HorizontalAlignment="Left"  FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="16" />
   </StackPanel>
  </Grid>


  <!-- Chat Request From -->
  <Grid Grid.Row="4" Height="auto" >

   <Grid.ColumnDefinitions>
    <ColumnDefinition Width="83"/>
    <ColumnDefinition Width="197"/>
   </Grid.ColumnDefinitions>

   <Image Style="{StaticResource ImageLogo}" Source="{Binding Source=new_omni_screenpop_incomingchat_icon, Converter={StaticResource CRMImageLoader}}" Grid.Column="0" />

   <Grid Grid.Column="1" Margin="20,6,14,3">
    <Grid.RowDefinitions>
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
    </Grid.RowDefinitions>
    <TextBlock Grid.Row="0" Style="{StaticResource DefaultTextForegroundStyle}" HorizontalAlignment="Left" Text="[[$Resources.ChatRequestTitle]]" FontWeight="Regular" VerticalAlignment="Center" FontSize="12" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="14" />
    <TextBlock Grid.Row="1" Style="{StaticResource DefaultTextForegroundStyle}" HorizontalAlignment="Left" FontWeight="SemiBold" Text="[[from]+]" VerticalAlignment="Center" FontSize="18" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="21"  />
    <TextBlock Grid.Row="2" Style="{StaticResource DesignationTextStyle}"  HorizontalAlignment="Left" Text="{Binding Source={StaticResource designation}}" FontWeight="Regular"  VerticalAlignment="Center" FontSize="12" TextTrimming="WordEllipsis" FontFamily="Segoe UI"  LineHeight="18"  />
   </Grid>

  </Grid>
  <!-- Separator line -->
  <Grid Grid.Row="5" Height="1" Opacity="0.13" >
   <Grid.Resources>
    <Style TargetType="{x:Type Grid}" >
     <Setter Property="Background" Value="#F1F1F1" />
     <Style.Triggers>
      <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
       <Setter Property="Background" Value="{DynamicResource HCWindowTextColor}"/>
      </DataTrigger>
     </Style.Triggers>
    </Style>
   </Grid.Resources>
   <Grid.RowDefinitions>
    <RowDefinition Height="1" />
   </Grid.RowDefinitions>
  </Grid>

  <!-- Attributes-->
  <Grid Grid.Row="6" Height="auto">
   <Grid.ColumnDefinitions>
    <ColumnDefinition Width="103"/>
    <ColumnDefinition Width="177"/>
   </Grid.ColumnDefinitions>

   <Grid Grid.Column="0" Height="auto" >
    <Grid.Resources>
     <Style TargetType="{x:Type Grid}" >
      <Setter Property="Margin" Value="14,14,11,7" />
      <Style.Triggers>
       <MultiDataTrigger>
        <MultiDataTrigger.Conditions>
         <Condition Binding="{Binding Source = {StaticResource jobTitle }}" Value="" />
         <Condition Binding="{Binding Source = {StaticResource email }}" Value="" />
         <Condition Binding="{Binding Source = {StaticResource city }}" Value="" />
         <Condition Binding="{Binding Source = {StaticResource state }}" Value="" />
        </MultiDataTrigger.Conditions>
        <Setter Property="Margin" Value="0,0,0,7" />
       </MultiDataTrigger>
      </Style.Triggers>
     </Style>
    </Grid.Resources>
    <Grid.RowDefinitions>
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
    </Grid.RowDefinitions>
    <TextBlock Style="{StaticResource JobTitleLabelStyle}" Grid.Row="0" Text="[[$Resources.JobTitleLabel]]" />
    <TextBlock Style="{StaticResource EmailLabelStyle}" Grid.Row="1" Text="[[$Resources.EmailLabel]]" />
    <TextBlock Style="{StaticResource CityLabelStyle}" Grid.Row="2" Text="[[$Resources.CityLabel]]" />
    <TextBlock Style="{StaticResource StateLabelStyle}"  Grid.Row="3" Text="[[$Resources.StateLabel]]" />
   </Grid>

   <Grid Grid.Column="1" Height="auto">
    <Grid.Resources>
     <Style TargetType="{x:Type Grid}" >
      <Setter Property="Margin" Value="14,14,11,7" />
      <Style.Triggers>
       <MultiDataTrigger>
        <MultiDataTrigger.Conditions>
         <Condition Binding="{Binding Source = {StaticResource jobTitle }}" Value="" />
         <Condition Binding="{Binding Source = {StaticResource email }}" Value="" />
         <Condition Binding="{Binding Source = {StaticResource city }}" Value="" />
         <Condition Binding="{Binding Source = {StaticResource state }}" Value="" />
        </MultiDataTrigger.Conditions>
        <Setter Property="Margin" Value="0,0,0,7" />
       </MultiDataTrigger>
      </Style.Triggers>
     </Style>
    </Grid.Resources>
    <Grid.RowDefinitions>
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
     <RowDefinition Height="auto" />
    </Grid.RowDefinitions>
    <TextBlock Style="{StaticResource TextBlockStyle}" Grid.Row="0" Text="[[jobTitle]+]" />
    <TextBlock Style="{StaticResource TextBlockStyle}" Grid.Row="1" Text="[[email]+]" />
    <TextBlock Style="{StaticResource TextBlockStyle}" Grid.Row="2" Text="[[city]+]" />
    <TextBlock Style="{StaticResource TextBlockStyle}" Grid.Row="3" Text="[[state]+]" />
   </Grid>
  </Grid>

  <!-- Accept / Reject Buttons -->
  <Grid Grid.Row="7" Height="auto">
   <Grid.ColumnDefinitions>
    <ColumnDefinition>
     <ColumnDefinition.Style>
      <Style TargetType="{x:Type ColumnDefinition}">
       <Setter Property="Width" Value="148" />
       <Style.Triggers>
        <DataTrigger Binding="{Binding Source={StaticResource isAccept}}" Value="FALSE" >
         <Setter Property="Width" Value="0" />
        </DataTrigger>
        <MultiDataTrigger>
         <MultiDataTrigger.Conditions>
          <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
          <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
         </MultiDataTrigger.Conditions>
         <Setter Property="Width" Value="148" />
        </MultiDataTrigger>
        <MultiDataTrigger>
         <MultiDataTrigger.Conditions>
          <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
          <Condition Binding="{Binding Source={StaticResource isReject}}" Value="FALSE" />
         </MultiDataTrigger.Conditions>
         <Setter Property="Width" Value="*" />
        </MultiDataTrigger>
       </Style.Triggers>
      </Style>
     </ColumnDefinition.Style>
    </ColumnDefinition>
    <ColumnDefinition>
     <ColumnDefinition.Style>
      <Style TargetType="{x:Type ColumnDefinition}">
       <Setter Property="Width" Value="132" />
       <Style.Triggers>
        <DataTrigger Binding="{Binding Source={StaticResource isReject}}" Value="FALSE" >
         <Setter Property="Width" Value="0" />
        </DataTrigger>
        <MultiDataTrigger>
         <MultiDataTrigger.Conditions>
          <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
          <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
         </MultiDataTrigger.Conditions>
         <Setter Property="Width" Value="132" />
        </MultiDataTrigger>
        <MultiDataTrigger>
         <MultiDataTrigger.Conditions>
          <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="FALSE" />
          <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
         </MultiDataTrigger.Conditions>
         <Setter Property="Width" Value="*" />
        </MultiDataTrigger>
       </Style.Triggers>
      </Style>
     </ColumnDefinition.Style>
    </ColumnDefinition>
   </Grid.ColumnDefinitions>

   <Button  Name="btnAccept" AutomationProperties.Name="[[$Resources.AcceptButtonText]]" Grid.Column="0" Height="40" Style="{StaticResource AcceptButton}" FontWeight="SemiBold" FontFamily="Segoe UI" Command="CCA:ActionCommands.UIIEvent" CommandParameter="CreateCustomerSession?cid=[[cid]+]&amp;from=[[from]+]&amp;isUniqueContactRecognized=[[isUniqueContactRecognized]+]&amp;CRMCONTACTID=[[CRMCONTACTID]+]&amp;CanActivateSession=[[CanActivateSession]+]&amp;SessionTabId=[[SessionTabId]+]">
    <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
     <Image Grid.Column="0" Style="{StaticResource ButtonImage}"  Source="{Binding Source=new_omni_screenpop_accept_icon, Converter={StaticResource CRMImageLoader}}" />
     <TextBlock Grid.Column="1" Text="[[$Resources.AcceptButtonText]]" VerticalAlignment="Center" FontWeight="SemiBold" Margin="5,0,0,0" />
    </StackPanel>
   </Button>

   <Button Name="btnReject" AutomationProperties.Name="[[$Resources.RejectButtonText]]" Grid.Column="1" Height="40" Style="{StaticResource RejectButton}" FontWeight="SemiBold" FontFamily="Segoe UI" Command="CCA:ActionCommands.UIIEvent" CommandParameter="IncomingRequestRejected?cid=[[cid]+]&amp;from=[[from]+]" >
    <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
     <Image Grid.Column="0" Style="{StaticResource ButtonImage}"  Source="{Binding Source=new_omni_screenpop_reject_icon, Converter={StaticResource CRMImageLoader}}" />
     <TextBlock Grid.Column="1" Text="[[$Resources.RejectButtonText]]" VerticalAlignment="Center" FontWeight="SemiBold" Margin="5,0,0,0" />
    </StackPanel>
   </Button>

  </Grid>
 </Grid>
</Border>
```

> [!div class="nextstepaction"]
> [Next topic: Step 2: Create hosted controls](alertnotification-step2-create-hosted-controls.md)

## See also

- [Configure notification for agents](configure-notification-screen-pop-agents.md)
- [Step 3: Create Omnichannel Alert Notification-related action call](alertnotification-step3-create-action-call-display-notification.md)
- [Step 4: Attach Omnichannel Alert Notification-related to the events](alertnotification-step4-add-action-calls-events.md)
- [Step 5: Add the hosted control, events, and action calls to the agent and supervisor configurations](alertnotification-step5-add-hosted-controls-events-action-callsagent-supervisor-configurations.md)
- [Configure toast notification in Unified Service Desk](configure-toast-notification-unified-service-desk.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]