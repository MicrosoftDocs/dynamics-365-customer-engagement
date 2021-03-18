---
title: "Panels, panel types, and panel layouts in Unified Service Desk | MicrosoftDocs"
description: "Learn about using panels to display hosted controls of various types. Various predefined panel types are available in Unified Service Desk to support a variety of layout options such as tabbed layout, deck layout, and stacked layout."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# Panels, panel types, and panel layouts in Unified Service Desk
[!INCLUDE[pn_unified_service_desk_for_crm](../includes/pn-unified-service-desk-for-crm.md)] uses panels to display hosted controls of various types. Various predefined panel types are available in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] to support a variety of layout options such as tabbed layout, deck layout, and stacked layout. You define the arrangement of these panels on the main screen of [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] using a **Panel Layout** hosted control. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Panel Layout (Hosted Control)](../unified-service-desk/panel-layout-hosted-control.md)

<a name="Panels"></a>
## Panels in Unified Service Desk
 Whenever you create a hosted control, you have to specify the panel that will hold it in the **Display Group** field of the **New Hosted Control** page. For most of the hosted control types, [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] automatically populates a panel value in the **Display Group** field. For example, **MainPanel** is used for a **CRM Page** type of hosted control and **ToolbarPanel** is used for the **Toolbar Container** type of hosted control.

 The following predefined panels are available in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].


|          Panel          |                                                                                      Description                                                                                      |
|-------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|        MainPanel        |                                                                        The main work area in the bottom right.                                                                        |
|        AboutPanel        |                                                                        The area in the top right. This panel displays Settings, Debug, About, any other configured options.                                                                        |
|        ChatPanel        |                                                   The typical location of the chat window. It is under the agent scripting control.                                                   |
|       HiddenPanel       |                                                    A nonvisible panel generally used for component without a user interface (UI).                                                     |
|       LeftPanel1        |                                                                 A panel just under the **WorkflowPanel** on the left.                                                                 |
|       LeftPanel2        |                                                                  A panel just under the **LeftPanel1** on the left.                                                                   |
|      LeftPanelFill      |                        A panel just under the **LeftPanel2**. This panel expands to fill the rest of the area available to the bottom edge of the left panel.                         |
|       RightPanel        |                                                                          A panel located on the right side.                                                                           |
|       CtiPanel \*       | A panel located in the top right, it is the default location for softphone controls. This is a stack panel so more than one control can be added and will show up next to each other. |
| SessionExplorerPanel \* |                                              A panel located just under the session tabs where you typically display the session lines.                                               |
|    WorkflowPanel \*     |                                       A panel located just under the **SessionExplorerPanel** and usually contains the agent scripting control.                                       |
|     ToolbarPanel \*     |          A panel at the very top just to the right of the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] logo, and typically holds the Toolbar.          |
|       RibbonPanel       |                                                                                For internal use only.                                                                                 |
|     StatusPanel \*      |                                                      A special panel located on the status bar at the bottom of the application.                                                      |

 \* These panels are generally reserved for special purposes so use of these should be avoided unless required.

 You can also assign keyboard shortcuts to panels so that customer service agents can directly access the panel in the client application by just using the keyboard. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Keyboard shortcuts for panels](../unified-service-desk/keyboard-shortcuts-panels.md)

<a name="PanelTypes"></a>
## Panel types in Unified Service Desk
 [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] provides the following predefined panel types to support a variety of layout options:


|      Panel Type      |                                                                                                                                                                                                                                                                               Description                                                                                                                                                                                                                                                                                |
|----------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|     USDTabPanel      |                                                                                   This panel type contains a tab control. Each hosted control is loaded on one of the tabs. The tab name displays the value specified in the **Display Name** filed of a hosted control. If no display name is specified for a hosted control, the hosted control name is displayed as the tab name. The tab control/header is displayed for this panel type if one or more hosted controls are on it.                                                                                   |
|    USDStackPanel     | This panel type stacks hosted controls in a horizontal or vertical fashion similar to a stack panel in [!INCLUDE[pn_ms_Windows_Presentation_Foundation](../includes/pn-ms-windows-presentation-foundation.md)]. These can be useful for toolbars or status bars, etc. This panel type is derived from StackPanel, which supports an [Orientation](https://msdn.microsoft.com/library/system.windows.controls.stackpanel.orientation\(v=vs.100\).aspx) property. This orientation should be defined in the XAML to define which way the hosted controls should be stacked. |
|   USDDeckTabPanel    |                                                                                                                    If a single hosted control is on this panel, the tabs are not shown. The tabs for a tab control are shown if two or more controls reside on this panel.<br /><br /> This control is the same as the **USDTabPanel** but a style exists in the default themes that will hide the tabs at the top, when only one control is loaded.                                                                                                                     |
|   USDCollapsePanel   |                                                                                                                                                                       This is the same as the **USDTabPanel** but a style in the default themes is defined that will automatically collapse this panel type so it no longer takes up space in the UI, if no hosted controls are loaded within it.                                                                                                                                                                        |
|   USDFloatingPanel   |                                                                                                                                          The default desktop provides an instance of this panel type. When “FloatingPanel” is specified for a hosted control, this panel type is being used. Typically you would not specify this panel type in your custom layout, however, it is exposed in case there is a reason to use it.                                                                                                                                          |
| USDFloatingToolPanel |                                                                                                 This panel type creates a tool window for each hosted control loaded into it. The default desktop provides an instance of this panel type. When “FloatingToolPanel” is specified for a hosted control, this panel type is being used. Typically you would not specify this panel type in your custom layout, however, it is exposed in case there is a reason to use it.                                                                                                 |
|    USDPopUpPanel     |                                                                                                                                                                                                                                          This panel type enables the content in the hosted control to hover over the main view.                                                                                                                                                                                                                                          |

 You can also use these predefined panel types to create a custom panel type in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a custom panel type](../unified-service-desk/create-custom-panel-type.md)

<a name="PanelLayouts"></a>
## Panel layouts in Unified Service Desk
 Use  a panel layout to define the arrangement of panels on the screen in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client. A panel layout is defined using a **Panel Layout** hosted control. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Panel Layout (Hosted Control)](../unified-service-desk/panel-layout-hosted-control.md)

 The following layout depicts the **Standard Main Panel** type of panel layout (also called standard panel layout) in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].

 ![Air theme in Unified Service Desk](../unified-service-desk/media/crm-itpro-usd-themeair.png "Air theme in Unified Service Desk")

> [!NOTE]
>  If you do not create any panel layout in your [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] configuration, the standard panel layout is used automatically to display panels and controls in the client application.
>
>  The full application area on the main window is defined as a panel itself, and is called `MainWorkArea`.While defining `XAML` or `User-Defined` type of panel layout, `MainWorkArea` is used as the panel value for the **Display Group** field.

 Because  panel layouts are hosted controls, you may use a panel layout anywhere you would have configured a hosted control. One common use for this is to define a split view in the main panel area. You might display a list view showing a list of accounts at the top and a detail view at the bottom. You might display a whole panel layout in the floating panel and show it on a second monitor. For more information about the usage of floating panes, see [Configure Pop In and Pop Out feature for knowledge base articles](../unified-service-desk/configure-unified-service-desk-use-dynamics-365-knowledge.md#PopInOut).

 [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] provides the following types of panel layouts:

 **Standard Main Panel**
 The standard panel layout provides the traditional layout including a series of panels on the left, collapsible area and a main work area on the right. The following is the XAML used to define the panel layout. You can also find this XAML in the [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] SDK. [Download](https://go.microsoft.com/fwlink/p/?LinkId=395257) the package, and extract it to view the `SamplePanelLayout.xaml`  file under the "UII\USD Developer Assets\USD Layout and Style Sheet" directory.

```xaml
<USD:PanelLayoutBase xmlns="https://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="https://schemas.microsoft.com/winfx/2006/xaml"
  xmlns:mc="https://schemas.openxmlformats.org/markup-compatibility/2006"
  xmlns:d="https://schemas.microsoft.com/expression/blend/2008"
  mc:Ignorable="d"
  xmlns:local="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics"
  xmlns:USD="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics.PanelLayouts;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics"
  d:DesignHeight="300"
  d:DesignWidth="300">
  <Grid x:Name="LayoutRoot">
    <Grid.Resources>
      <local:CRMImageConverter x:Key="CRMImageLoader" />
    </Grid.Resources>
    <Grid.RowDefinitions>
      <RowDefinition Height="40"/>
      <RowDefinition Height="*"/>
      <RowDefinition Height="30"/>
    </Grid.RowDefinitions>
    <Border Grid.Row="0"
            BorderBrush="#d8d8d8"
            BorderThickness="0,1,0,1">
      <Grid Background="{DynamicResource WindowHeaderStyle}"
            Grid.Row="0"
            Margin="0">
        <Grid.ColumnDefinitions>
          <ColumnDefinition Width="auto" />
          <ColumnDefinition Width="auto" />
          <ColumnDefinition Width="*" />
          <ColumnDefinition Width="Auto" />
        </Grid.ColumnDefinitions>
        <Image Style="{DynamicResource USDLogo}"
               Grid.Column="0"
               ToolTip="Unified Service Desk"
               AutomationProperties.Name="Unified Service Desk" />
        <Rectangle Width="10"
                   Grid.Column="1" />
        <USD:USDDeckTabPanel x:Name="ToolbarPanel"
                             Grid.Column="2"
                             AutomationProperties.Name="Toolbar Panel"
                             VerticalAlignment="Center"
                             Focusable="True"
                             Margin="0"
                             USD:PanelNavigation.KeyboardShortcut="CTRL+1"/>
        <Grid Grid.Column="3"
              Background="{DynamicResource AboutPanelStandardBackground}">
          <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*" />
            <ColumnDefinition Width="412"/>
          </Grid.ColumnDefinitions>
          <USD:USDStackPanel Grid.Column="0"
                             x:Name="CtiPanel"
                             Orientation="Horizontal"
                             Focusable="True"
                             VerticalAlignment="Center"
                             AutomationProperties.Name="Cti Panel"/>
          <USD:USDStackPanel Grid.Column="1"
                             HorizontalAlignment="Right"
                             x:Name="AboutPanel"
                             Orientation="Horizontal"
                             Focusable="True"
                             VerticalAlignment="Center"
                             AutomationProperties.Name="AboutPanel"
                             USD:PanelNavigation.KeyboardShortcut="CTRL+2"/>
        </Grid>
      </Grid>
    </Border>
    <Grid Grid.Row="1"
          VerticalAlignment="Stretch"
          Margin="0"
          Background="{DynamicResource WindowBackgroundStyle}">
      <Grid.RowDefinitions>
        <RowDefinition Height="auto" />
        <RowDefinition Height="*" />
        <RowDefinition Height="auto" />
      </Grid.RowDefinitions>
      <USD:USDDeckTabPanel x:Name="SessionTabsPanel"
                           Grid.Row="0"
                           Margin="5,5,0,5"
                           AutomationProperties.Name="Session Tabs Panel"
                           Focusable="True"
                           ClipToBounds="True"
                           USD:PanelNavigation.KeyboardShortcut="CTRL+3"/>
      <Grid x:Name="MainGrid"
            Grid.Row="1"
            AutomationProperties.Name="Main Panels">
        <Grid.ColumnDefinitions>
          <ColumnDefinition Width="auto" />
          <ColumnDefinition Width="*"/>
          <ColumnDefinition Width="auto"/>
        </Grid.ColumnDefinitions>
        <Expander Grid.Column="0"
                  Style="{DynamicResource StretchExpanderStyle}"
                  ExpandDirection="Left"
                  x:Name="ExpanderSessionDetails"
                  IsExpanded="false"
                  BorderBrush="White" >
          <ScrollViewer VerticalScrollBarVisibility="Auto" >
            <Grid Style="{DynamicResource LeftPanelGrid}"
                  Margin="5">
              <Grid.RowDefinitions>
                <RowDefinition Height="auto" />
                <RowDefinition Height="auto" />
                <RowDefinition Height="auto"
                               Name="ChatPanelRow" />
                <RowDefinition Height="auto" />
                <RowDefinition Height="auto" />
                <RowDefinition Height="auto" />
              </Grid.RowDefinitions >
              <USD:USDCollapsePanel x:Name="SessionExplorerPanel"
                                    AutomationProperties.Name="Session Explorer Panel"
                                    Grid.Row="0"
                                    Margin="1"
                                    USD:PanelNavigation.KeyboardShortcut="CTRL+4"/>
              <USD:USDCollapsePanel x:Name="WorkflowPanel"
                                    AutomationProperties.Name="Workflow Panel"
                                    Grid.Row="1"
                                    Margin="1"
                                    USD:PanelNavigation.KeyboardShortcut="CTRL+5"/>
              <USD:USDCollapsePanel x:Name="ChatPanel"
                                    AutomationProperties.Name="Workflow Panel"
                                    Grid.Row="2"
                                    Margin="1"/>
              <USD:USDCollapsePanel x:Name="LeftPanel1"
                                    AutomationProperties.Name="Left Panel 1"
                                    Grid.Row="3"
                                    Margin="1"/>
              <USD:USDCollapsePanel x:Name="LeftPanel2"
                                    AutomationProperties.Name="Left Panel 2"
                                    Grid.Row="4"
                                    Margin="1"/>
              <USD:USDTabPanel x:Name="LeftPanelFill"
                               AutomationProperties.Name="Left Panel Fill"
                               Grid.Row="5"
                               Margin="1"
                               MinHeight="300"
                               USD:PanelNavigation.KeyboardShortcut="CTRL+6"/>
            </Grid>
          </ScrollViewer>

        </Expander>
        <Grid Grid.Column="1"
              Background="Transparent">
          <Grid.RowDefinitions>
            <RowDefinition Height="0" />
            <RowDefinition Height="79*" />
            <RowDefinition Height="125*"/>
          </Grid.RowDefinitions>
          <USD:USDCollapsePanel x:Name="RibbonPanel"
                                Grid.Row="0"
                                Visibility="Collapsed"
                                AutomationProperties.Name="Ribbon Panel"
                                Focusable="True"
                                Margin="1"
                                ClipToBounds="False"
                                SnapsToDevicePixels="True"/>
          <USD:USDTabPanel x:Name="MainPanel"
                           Grid.Row="1"
                           AutomationProperties.Name="Main Panel"
                           Grid.RowSpan="2"
                           USD:PanelNavigation.KeyboardShortcut="CTRL+7"/>
        </Grid>
        <Expander Grid.Column="2"
                  Style="{DynamicResource StretchExpanderStyle}"
                  ExpandDirection="Right"
                  x:Name="RightPanelExpander"
                  IsExpanded="false"
                  BorderBrush="White" >
          <ScrollViewer VerticalScrollBarVisibility="Auto" >
            <Grid Style="{DynamicResource LeftPanelGrid}" >
              <Grid.RowDefinitions>
                <RowDefinition Height="*" />
              </Grid.RowDefinitions >
              <USD:USDTabPanel x:Name="RightPanel"
                               AutomationProperties.Name="Right Panel"
                               Grid.Row="0"
                               USD:PanelNavigation.KeyboardShortcut="CTRL+8"/>
              <USD:USDPopupPanel x:Name="RightPopupPanel"
                                 Height="{Binding ActualHeight, ElementName=RightPanel, Mode=OneWay}"
                                 Width="{Binding ActualWidth, ElementName=RightPanel, Mode=OneWay}"
                                 Placement="Left"
                                 PlacementTarget="{Binding ElementName=RightPanel}"
                                 PopupAnimation="Scroll"
                                 USD:PanelNavigation.KeyboardShortcut="CTRL+9">
                <Grid>
                  <Grid.RowDefinitions>
                    <RowDefinition Height="20" />
                    <RowDefinition Height="*" />
                  </Grid.RowDefinitions>
                  <Border Background="#cccccc"
                          Grid.Row="0" >
                    <TextBlock Text="Article Preview"
                               HorizontalAlignment="Center"
                               Margin="10,0,0,0" />
                  </Border>
                  <Border BorderThickness="1"
                          Grid.Row="1"
                          BorderBrush="#cccccc"
                          Background="White">
                    <ContentControl  Margin="0,0,0,0"
                                     Name="PopupContainer"
                                     Style="{DynamicResource USDContentControlStyle}"/>
                  </Border>
                </Grid>
              </USD:USDPopupPanel>
            </Grid>
          </ScrollViewer>
        </Expander>
      </Grid>
    </Grid>
    <StatusBar Grid.Row="2"
               Style="{DynamicResource StatusBarStyle}">
      <StatusBarItem>
        <TextBlock x:Name="lblStatusBarClock"
                   Text="00:00 AM/PM"
                   Style="{DynamicResource StatusBarClockLabelStyle}"/>
      </StatusBarItem>
      <Separator Style="{DynamicResource StatusBarSeparatorStyle}"/>
      <StatusBarItem >
        <USD:USDStackPanel x:Name="StatusPanel"
                           Orientation="Horizontal"
                           AutomationProperties.Name="Status Panel"
                           Margin="1"/>
      </StatusBarItem>
    </StatusBar>
  </Grid>
</USD:PanelLayoutBase>
```

 **Ribbon Main Panel**
 For internal use only.

 **Horizontal Split**
 This is a special layout typically used within the MainPanel as a hosted control. It contains a splitter with a top panel and a bottom panel. It is typically used to display a list view at top and a detail view at the bottom similar to Outlook. Two panels are defined in this layout.

|Panel Name|Description|
|----------------|-----------------|
|TopPanel|This is the panel that displays on top. It is defined as:<br /><br /> USDDeckTabPanel|
|BottomPanel|This is the panel that displays on bottom. It is defined as:<br /><br /> USDDeckTabPanel|

 This panel supports the following actions:


|        Action        |                                                                                                                                                                                                                                                                                              Description                                                                                                                                                                                                                                                                                              |
|----------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|  SetTopPanelHeight   | This action can be used to set the top panel height. It supports two parameters, height and type.<br /><br /> Type can be any of the following values:<br /><br /> - **Auto**: sized to fix components inside<br />- **Pixel**: the number of pixels<br />- **Star**: takes the remaining space<br /><br /> The interpretation of the height parameter depends on this type value. For more information, see the [!INCLUDE[pn_ms_Windows_Presentation_Foundation](../includes/pn-ms-windows-presentation-foundation.md)][documentation](https://msdn.microsoft.com/library/ms754130\(v=vs.100\).aspx). |
| SetBottomPanelHeight |                                              This action can be used to set the bottom panel height. It supports two parameters, height and type.<br /><br /> Type can be any of the following values:<br /><br /> - **Auto**: sized to fix components inside<br />- **Pixel**: the number of pixels<br />- **Star**: takes the remaining space<br /><br /> The interpretation of the height parameter depends on this type value. For more information, see the WPF [documentation](https://msdn.microsoft.com/library/ms754130\(v=vs.100\).aspx).                                              |

 **Vertical Split**
 This is a special layout that contains a vertical splitter with a left panel and a right panel.

|Panel Name|Description|
|----------------|-----------------|
|LeftPanel|This is the panel that displays on left. It is defined as:<br /><br /> USDDeckTabPanel|
|RightPanel|This is the panel that displays on right. It is defined as:<br /><br /> USDDeckTabPanel|

 This panel supports the following actions:

|Action|Description|
|------------|-----------------|
|SetLeftPanelWidth|This action can be used to set the left panel width. It supports two parameters, width and type.<br /><br /> Type can be any of the following values:<br /><br /> - **Auto**: sized to fix components inside<br />- **Pixel**: the number of pixels<br />- **Star**: takes the remaining space<br /><br /> The interpretation of the width parameter depends on this type value. For more information, see the WPF [documentation](https://msdn.microsoft.com/library/ms754130\(v=vs.100\).aspx).|
|SetRightPanelWidth|This action can be used to set the right panel width. It supports two parameters, width and type.<br /><br /> Type can be any of the following values:<br /><br /> - **Auto**: sized to fix components inside<br />- **Pixel**: the number of pixels<br />- **Star**: takes the remaining space<br /><br /> The interpretation of the width parameter depends on this type value. See the WPF documentation for more details.|

 **XAML**
 One of the quickest ways to create a custom layout. However, this option does not support code-behind. As a result, if you can’t describe your layout without code, you can’t use this option and should instead use the **User Defined** option. For more information, see [Code-Behind and XAML in WPF](https://msdn.microsoft.com/library/aa970568\(v=vs.100\).aspx).

 Here is an example of a XAML layout.

```xaml
<Grid xmlns="https://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="https://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:mc="https://schemas.openxmlformats.org/markup-compatibility/2006"
    xmlns:d="https://schemas.microsoft.com/expression/blend/2008"
    mc:Ignorable="d" xmlns: USD="clr-namespace:Dynamics.PanelLayouts;assembly=Dynamics">
 <Grid.RowDefinitions>
 <RowDefinition Height="*" x:Name="TopPanelRow" />
 <RowDefinition Height="auto" />
 <RowDefinition Height="*" x:Name="BottomPanelRow" />
 </Grid.RowDefinitions>
 < USD: USDDeckTabPanel Grid.Row="1" x:Name="TopPanel" Focusable="False" ClipToBounds="True" />
 <GridSplitter Height="5" Grid.Row="2" VerticalAlignment="Top" HorizontalAlignment="Stretch" ResizeDirection="Rows" ResizeBehavior="PreviousAndNext" />
 <USD: USDDeckTabPanel Grid.Row="3" x:Name="BottomPanel" />
</Grid>
```

 **User Defined**
 This setting allows you to build a hosted control with [code behind](https://msdn.microsoft.com/library/aa970568\(v=vs.100\).aspx) to gain the full features of .NET in handling your layout.

 For details about what panel types can be defined and used in a user defined panel, see [Panel types](../unified-service-desk/panels-panel-types-panel-layouts.md#PanelTypes).

 For information about creating a custom panel layout, see [Create a custom panel layout](../unified-service-desk/create-custom-panel-layout.md).

### See also
 [Use custom panel types and panel layouts](../unified-service-desk/use-custom-panel-types-panel-layouts-unified-service-desk.md)
 [Keyboard shortcuts for panels](../unified-service-desk/keyboard-shortcuts-panels.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]