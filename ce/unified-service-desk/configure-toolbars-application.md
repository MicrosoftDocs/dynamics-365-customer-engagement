---
title: "Configure toolbars in your application | MicrosoftDocs"
description: "Learn about configuring toolbars in your application."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 12/31/2019
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
# Configure toolbars in your application
You can configure toolbars in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] to create or manage buttons in an existing toolbar, or create new toolbars altogether. For an overview of toolbars, see [Toolbars in Unified Service Desk](../unified-service-desk/toolbars-unified-service-desk.md).  
  
<a name="Create"></a>  

## Create a toolbar  
 Before creating a toolbar, ensure that there is a toolbar container hosted control already configured. For more information, see [Toolbar Container (Hosted Control)](../unified-service-desk/toolbar-container-hosted-control.md).  
  
1. Sign in to Unified Service Desk Administrator.  
  
2. Select **Toolbars** under **Basic Settings**.  
  
3. Select **+ New**.  
  
4. On the **New Toolbar** page, and.  
  
   1.  Type a name for the new toolbar.  
  
   2.  Type a title for the toolbar, which is displayed on the left edge of the toolbar strip.  
  
   3.  Select **Save** to enable the **Buttons** area.  
  
5. Under the **Buttons** area, select **+ New Toolbar Button** to create a button to be placed on the toolbar.
  
6. On the **New Toolbar Button** page:  
  
   1.  Specify the name of the button.  
  
   2.  Specify the name of the image file for the toolbar button.  
  
   3.  In the **ButtonText** field, type the label of the button.  
  
   4.  To control the left to right order in which the buttons are displayed on the toolbar, specify an integer value in the **Order** field. The buttons are arranged from left to right in the ascending order.  
  
   5.  Select **Save** to enable the **Actions** area.  
  
7. Under the **Actions** area, select **Add Existing Action Call** to add an action call to the button. The **Lookup Records** pane is displayed.
  
8. In the search box in Under the **Actions** area, type the name of the action call that you want to attach to the button. Select the action call from the list and then select **Add**. 

    If you want to attach the button to a new action call, select **New**, and then add create an action call and then add it to the UII action. For more information, see [Create an action call for a UII action](../unified-service-desk/create-action-call-uii-action.md).  
  
9. For additional button on the toolbar, follow steps 5-8.  
  
10. After adding buttons and action calls to a toolbar, attach the toolbar to a toolbar container. This is done to specify the location of the new toolbar on the desktop of in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. With the toolbar definition open, select the **Related** tab, and then select **Hosted Controls**.  
  
11. On the next page, select **Add Existing Hosted Control**.  The **Lookup Records** pane is displayed.
  
12. In the search box, type the name of the toolbar container hosted control, select search, and then select the hosted control from the list, and then select **Add**.  
  
13. Select **Save**. 

14. Under the **Styles** area, in the **Custom Styles** text box, write the XAML string to customize the toolbar and buttons. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Styles in toolbar](#styles-in-toolbar)

15. Select **Save**. 
  
<a name="EditToolbar"></a> 

## Add/remove button from existing toolbar  
  
1. Sign in to Unified Service Desk Administrator.  
  
2. Select **Toolbars** under **Basic Settings**.  
  
4. On the toolbars page, select the name of the toolbar that you want to modify.  
  
5. The next page displays the toolbar definition.  
  
   1.  Add more buttons using the **Buttons** area. For more information, see steps 6-10 as in the previous section.  
  
   2.  Modify an existing button by selecting the button name under the **Buttons**. This opens the button definition page where you can change information about the button, such as name, button text (label), order, and action call.  
  
   3.  select **Save** to save the changes.

<a name="StylesToolbar"></a>  
 
## Styles in toolbar

You can now customize the toolbar in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] using the custom styles field in the Toolbar configuration window.  The Custom Styles field supports Extensible Application Markup Language (XAML) that defines <xref:System.Windows.ResourceDictionary> of <xref:System.Windows.Style> and <xref:System.Windows.Media.Brush> resources.
 
The resources in the dictionary refers to other resources that are available on [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application. Loading and parsing the XAML string is performed at runtime to create <xref:System.Windows.ResourceDictionary> and merge the resources of the toolbar control with the <xref:System.Windows.ResourceDictionary>. In addition, the <xref:System.Windows.ResourceDictionary> can have styles for button types inside a toolbar. Using the styles, you can customize the toolbars and buttons.

**Sample 1:**
  The sample XAML that defines <xref:System.Windows.ResourceDictionary> of <xref:System.Windows.Style> and <xref:System.Windows.Media.Brush> resources demonstrates customizing the **About Tool bar**.

> [!NOTE]
> You can find this sample XAML styles in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] - Unified Interface sample package.

  ```XAML
  <ResourceDictionary xmlns="https://schemas.microsoft.com/winfx/2006/xaml/presentation" 
  xmlns:x="https://schemas.microsoft.com/winfx/2006/xaml" 
  xmlns:usd="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics" 
  xmlns:controlStyles="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics.Controls.Styles;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics" 
  xmlns:usdPanelLayouts="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics.PanelLayouts;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics" 
  xmlns:themes="clr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Luna" 
  xmlns:control="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics.Controls;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics"> 
  
    <Style x:Key="ToolBarMainPanelBorderStyle" TargetType="{x:Type Border}"> 
          <Setter Property="Margin" Value="0,0,0,0"/> 
          <Setter Property="CornerRadius" Value="3,3,3,3"/> 
          <Setter Property="KeyboardNavigation.TabNavigation" Value="Continue"/> 
          <Style.Triggers> 
              <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true"> 
                  <Setter Property="CornerRadius" Value="0,0,0,0"/> 
              </DataTrigger> 
          </Style.Triggers> 
      </Style> 
  
  <Style x:Key="ToolBarThumbStyle" TargetType="{x:Type Thumb}"> 
          <Setter Property="Template"> 
              <Setter.Value> 
                  <ControlTemplate TargetType="{x:Type Thumb}"> 
                      <Border Background="Transparent" Padding="{TemplateBinding Padding}" SnapsToDevicePixels="True"> 
                          <Rectangle> 
                              <Rectangle.Fill> 
                                  <DrawingBrush TileMode="Tile" Viewbox="0,0,4,4" Viewport="0,0,4,4" ViewportUnits="Absolute" ViewboxUnits="Absolute"> 
                                      <DrawingBrush.Drawing> 
                                          <DrawingGroup> 
                                              <GeometryDrawing Brush="White" Geometry="M 1 1 L 1 3 L 3 3 L 3 1 z"/> 
                                              <GeometryDrawing Brush="{DynamicResource ToolBarGripper}" Geometry="M 0 0 L 0 2 L 2 2 L 2 0 z"/> 
                                          </DrawingGroup> 
                                      </DrawingBrush.Drawing> 
                                  </DrawingBrush> 
                              </Rectangle.Fill> 
                          </Rectangle> 
                      </Border> 
                      <ControlTemplate.Triggers> 
                          <Trigger Property="IsMouseOver" Value="true"> 
                              <Setter Property="Cursor" Value="SizeAll"/> 
                          </Trigger> 
                      </ControlTemplate.Triggers> 
                  </ControlTemplate> 
              </Setter.Value> 
          </Setter> 
      </Style> 
  
  <Style x:Key="ToolBarHorizontalOverflowButtonStyle" TargetType="{x:Type ToggleButton}"> 
  <Setter Property="Background" Value="Transparent"/> 
  <Setter Property="MinHeight" Value="0"/> 
  <Setter Property="MinWidth" Value="0"/> 
  <Setter Property="KeyboardNavigation.TabNavigation" Value="Continue"/> 
  <Setter Property="Template"> 
  <Setter.Value> 
  <ControlTemplate TargetType="{x:Type ToggleButton}"> 
  <Border x:Name="Bd" Background="Transparent" CornerRadius="0" SnapsToDevicePixels="true"> 
  <Image Source="{DynamicResource ImageMoreToolBarButtons}" Margin="7,5,7,5" Width="16" Height="16" VerticalAlignment="Bottom" HorizontalAlignment="Right" 
    AutomationProperties.Name="More Menu"></Image> 
  </Border> 
  <ControlTemplate.Triggers> 
  <Trigger Property="IsMouseOver" Value="true"> 
  <Setter Property="Background" TargetName="Bd" Value="{DynamicResource USDTabBackgroundBrush}"/> 
  </Trigger> 
  <Trigger Property="IsKeyboardFocused" Value="true"> 
  <Setter Property="Background" TargetName="Bd" Value="{DynamicResource USDTabBackgroundBrush}"/> 
  <Setter Property="KeyboardNavigation.TabNavigation" Value="Continue"/> 
  </Trigger> 
  <Trigger Property="IsEnabled" Value="false"> 
  <Setter Property="Foreground" Value="{DynamicResource ToolBarGripper}"/> 
  </Trigger> 
  </ControlTemplate.Triggers> 
  </ControlTemplate> 
  </Setter.Value> 
  </Setter> 
  <Style.Triggers> 
  <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true"> 
  <Setter Property="Background" Value="Transparent"/> 
  </DataTrigger> 
  </Style.Triggers> 
  </Style> 
  
  <Style x:Key="MainToolBarFocusVisual"> 
      <Setter Property="Control.Template"> 
        <Setter.Value> 
          <ControlTemplate> 
            <Rectangle SnapsToDevicePixels="true" Stroke="White" 
                    StrokeDashArray="1 2" StrokeThickness="1"/> 
          </ControlTemplate> 
        </Setter.Value> 
      </Setter> 
    </Style> 
  
  
  <Style x:Key="ToolBarVerticalOverflowButtonStyle" TargetType="{x:Type ToggleButton}"> 
  <Setter Property="Background" Value="{DynamicResource NormalBrush}"/> 
  <Setter Property="MinHeight" Value="0"/> 
  <Setter Property="MinWidth" Value="0"/> 
  <Setter Property="KeyboardNavigation.TabNavigation" Value="Continue"/> 
  <Setter Property="KeyboardNavigation.DirectionalNavigation" Value="Continue"/> 
  <Setter Property="Template"> 
  <Setter.Value> 
  <ControlTemplate TargetType="{x:Type ToggleButton}"> 
  <Border x:Name="Bd" Background="Transparent" CornerRadius="0" SnapsToDevicePixels="true"> 
  <Image Source="{DynamicResource ImageMoreToolBarButtons}" Margin="7,5,7,5" Width="16" Height="16" VerticalAlignment="Bottom" HorizontalAlignment="Right" 
    AutomationProperties.Name="More Menu"></Image> 
  </Border> 
  <ControlTemplate.Triggers> 
  <Trigger Property="IsMouseOver" Value="true"> 
  <Setter Property="Background" TargetName="Bd" Value="{DynamicResource USDTabBackgroundBrush}"/> 
  </Trigger> 
  <Trigger Property="IsKeyboardFocused" Value="true"> 
  <Setter Property="Background" TargetName="Bd" Value="{DynamicResource USDTabBackgroundBrush}"/> 
  <Setter Property="KeyboardNavigation.TabNavigation" Value="Continue"/> 
  </Trigger> 
  <Trigger Property="IsEnabled" Value="false"> 
  <Setter Property="Foreground" Value="{DynamicResource ToolBarGripper}"/> 
  </Trigger> 
  </ControlTemplate.Triggers> 
  </ControlTemplate> 
  </Setter.Value> 
  </Setter> 
  <Style.Triggers> 
  <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true"> 
  <Setter Property="Background" Value="Transparent"/> 
  </DataTrigger> 
  </Style.Triggers> 
  </Style> 
  
  <Style TargetType="{x:Type ToolBar}"> 
  <Setter Property="Background" Value="Transparent"/> 
  <Setter Property="KeyboardNavigation.TabNavigation" Value="Local"/> 
  <Setter Property="KeyboardNavigation.DirectionalNavigation" Value="Continue"/> 
  <Setter Property="Template"> 
  <Setter.Value> 
  <ControlTemplate TargetType="{x:Type ToolBar}"> 
  <Grid x:Name="Grid" Margin="0,0,0,0" SnapsToDevicePixels="true" Height="42"> 
  <Grid x:Name="OverflowGrid" HorizontalAlignment="Right" Margin="0,0,-11,0"> 
  <ToggleButton x:Name="OverflowButton" ClickMode="Press" FocusVisualStyle="{x:Null}" IsChecked="{Binding IsOverflowOpen, Mode=TwoWay, RelativeSource={RelativeSource TemplatedParent}}"  
    IsEnabled="{TemplateBinding HasOverflowItems}" Style="{StaticResource ToolBarHorizontalOverflowButtonStyle}" Visibility="Collapsed" 
    Margin="0,0,0,5"> 
  </ToggleButton> 
  <Popup x:Name="OverflowPopup" AllowsTransparency="true" Focusable="True" IsOpen="{Binding IsOverflowOpen, RelativeSource={RelativeSource TemplatedParent}}" PopupAnimation="{DynamicResource {x:Static SystemParameters.ComboBoxPopupAnimationKey}}" Placement="Bottom" StaysOpen="false"> 
  <themes:SystemDropShadowChrome x:Name="Shdw" Color="Transparent"> 
  <Border x:Name="ToolBarSubMenuBorder" BorderBrush="{DynamicResource ToolBarMenuBorder}" BorderThickness="1" Background="{DynamicResource ToolBarSubMenuBackground}" RenderOptions.ClearTypeHint="Enabled"> 
  <ToolBarOverflowPanel x:Name="PART_ToolBarOverflowPanel" KeyboardNavigation.DirectionalNavigation="Continue" FocusVisualStyle="{x:Null}" Focusable="true" SnapsToDevicePixels="{TemplateBinding SnapsToDevicePixels}" KeyboardNavigation.TabNavigation="Cycle" WrapWidth="200"/> 
  </Border> 
  </themes:SystemDropShadowChrome> 
  </Popup> 
  </Grid> 
  <Border x:Name="MainPanelBorder" BorderBrush="{TemplateBinding BorderBrush}" BorderThickness="{TemplateBinding BorderThickness}" Background="{TemplateBinding Background}" Padding="{TemplateBinding Padding}" Style="{StaticResource ToolBarMainPanelBorderStyle}"> 
  <DockPanel KeyboardNavigation.TabIndex="1" KeyboardNavigation.TabNavigation="Local"> 
  <Thumb x:Name="ToolBarThumb" Margin="-3,-1,0,0" Padding="6,5,1,6" Style="{StaticResource ToolBarThumbStyle}"/> 
  <ContentPresenter x:Name="ToolBarHeader" ContentSource="Header" HorizontalAlignment="Center" Margin="4,0,4,0" SnapsToDevicePixels="{TemplateBinding SnapsToDevicePixels}" VerticalAlignment="Center"/> 
  <ToolBarPanel x:Name="PART_ToolBarPanel" IsItemsHost="true" Margin="0" SnapsToDevicePixels="{TemplateBinding SnapsToDevicePixels}"/> 
  </DockPanel> 
  </Border> 
  </Grid> 
  <ControlTemplate.Triggers> 
  <Trigger Property="HasOverflowItems" Value="true"> 
  <Setter Property="Visibility" TargetName="OverflowButton" Value="Visible"/> 
  </Trigger> 
  <Trigger Property="IsOverflowOpen" Value="true"> 
  <Setter Property="IsEnabled" TargetName="ToolBarThumb" Value="false"/> 
  </Trigger> 
  <Trigger Property="Header" Value="{x:Null}"> 
  <Setter Property="Visibility" TargetName="ToolBarHeader" Value="Collapsed"/> 
  </Trigger> 
  <Trigger Property="ToolBarTray.IsLocked" Value="true"> 
  <Setter Property="Visibility" TargetName="ToolBarThumb" Value="Collapsed"/> 
  </Trigger> 
  <Trigger Property="HasDropShadow" SourceName="OverflowPopup" Value="true"> 
  <Setter Property="Margin" TargetName="Shdw" Value="0,0,5,5"/> 
  <Setter Property="SnapsToDevicePixels" TargetName="Shdw" Value="true"/> 
  <Setter Property="Color" TargetName="Shdw" Value="#71000000"/> 
  </Trigger> 
  <Trigger Property="Orientation" Value="Vertical"> 
  <Setter Property="Margin" TargetName="Grid" Value="1,3,1,1"/> 
  <Setter Property="Style" TargetName="OverflowButton" Value="{StaticResource ToolBarVerticalOverflowButtonStyle}"/> 
  <Setter Property="Height" TargetName="ToolBarThumb" Value="10"/> 
  <Setter Property="Width" TargetName="ToolBarThumb" Value="Auto"/> 
  <Setter Property="Margin" TargetName="ToolBarThumb" Value="-1,-3,0,0"/> 
  <Setter Property="Padding" TargetName="ToolBarThumb" Value="5,6,6,1"/> 
  <Setter Property="Margin" TargetName="ToolBarHeader" Value="0,0,0,4"/> 
  <Setter Property="Margin" TargetName="PART_ToolBarPanel" Value="1,0,2,2"/> 
  <Setter Property="DockPanel.Dock" TargetName="ToolBarThumb" Value="Top"/> 
  <Setter Property="DockPanel.Dock" TargetName="ToolBarHeader" Value="Top"/> 
  <Setter Property="HorizontalAlignment" TargetName="OverflowGrid" Value="Stretch"/> 
  <Setter Property="VerticalAlignment" TargetName="OverflowGrid" Value="Bottom"/> 
  <Setter Property="Placement" TargetName="OverflowPopup" Value="Right"/> 
  <Setter Property="Margin" TargetName="MainPanelBorder" Value="0,0,0,11"/> 
  <Setter Property="Background" Value="Transparent"/> 
  <Setter Property="KeyboardNavigation.TabNavigation" Value="Local"/> 
  <Setter Property="KeyboardNavigation.DirectionalNavigation" Value="Continue"/> 
  </Trigger> 
  <Trigger Property="IsEnabled" Value="false"> 
  <Setter Property="Foreground" Value="{DynamicResource {x:Static SystemColors.GrayTextBrushKey}}"/> 
  </Trigger> 
  </ControlTemplate.Triggers> 
  </ControlTemplate> 
  </Setter.Value> 
  </Setter> 
  <Style.Triggers> 
  <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true"> 
  <Setter Property="Background" Value="Transparent"/> 
  </DataTrigger> 
  </Style.Triggers> 
  </Style> 
  
  <Style x:Key="ToolBarButtonBaseStyle"> 
  <Setter Property="Control.BorderThickness" Value="0"/> 
  <Setter Property="Control.Padding" Value="0"/> 
  <Setter Property="Control.Background" Value="Transparent"/> 
  <Setter Property="Control.BorderBrush" Value="Transparent"/> 
  <Setter Property="Control.Foreground" Value="{DynamicResource ToolBarFontColor}"/> 
  <Setter Property="Control.FontFamily" Value="Segoe UI"/> 
  <Setter Property="Control.FontSize" Value="12"/> 
  </Style> 
  <Style x:Key="ToolbarButtonTemplate" TargetType="{x:Type control:ToolbarButton}" BasedOn="{StaticResource ToolBarButtonBaseStyle}"> 
          <Setter Property="HorizontalContentAlignment" Value="Center"/> 
          <Setter Property="VerticalContentAlignment" Value="Center"/> 
          <Setter Property="VerticalAlignment" Value="Center"/> 
          <Setter Property="FontFamily" Value="Segoe UI"/> 
          <Setter Property="FontSize" Value="14"/> 
          <Setter Property="FocusVisualStyle" Value="{DynamicResource MainToolBarFocusVisual}" /> 
          <Setter Property="Template"> 
              <Setter.Value> 
                  <ControlTemplate TargetType="{x:Type control:ToolbarButton}"> 
                      <Border x:Name="Bd" Height="42"  BorderBrush="{TemplateBinding BorderBrush}" BorderThickness="{TemplateBinding BorderThickness}" Background="{TemplateBinding Background}" Padding="{TemplateBinding Padding}" SnapsToDevicePixels="true"> 
                          <StackPanel x:Name="AboutToolBarButtonStackPanel"  Orientation="Horizontal" Margin="7,0,7,0"> 
                              <Image Margin="0,0,7,0" x:Name="Icon" VerticalAlignment="Center" MaxWidth="16" MaxHeight="16" Source="{TemplateBinding Image}"/> 
                              <ContentPresenter Margin="0,7,0,7"  HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}" SnapsToDevicePixels="{TemplateBinding SnapsToDevicePixels}" VerticalAlignment="{TemplateBinding VerticalContentAlignment}"/> 
                          </StackPanel> 
                      </Border> 
                      <ControlTemplate.Triggers> 
                          <Trigger Property="Text" Value="{x:Null}"> 
                              <Setter TargetName="Icon" Property="Margin" Value="0,0,0,0"/> 
                              <Setter TargetName="AboutToolBarButtonStackPanel" Property="Margin" Value="13,0,13,0"/> 
                          </Trigger> 
                          <Trigger Property="Image" Value="{x:Null}"> 
                              <Setter TargetName="Icon" Property="Visibility" Value="Collapsed"/> 
                          </Trigger> 
                          <Trigger Property="IsMouseOver" Value="true"> 
                              <Setter Property="Background" TargetName="Bd" Value="{DynamicResource ToolBarButtonHover}"/> 
                              <Setter Property="Foreground" Value="{DynamicResource ToolBarTextFontHighlightColor}"/> 
                          </Trigger> 
                          <Trigger Property="IsKeyboardFocused" Value="true"> 
                              <Setter Property="Background" TargetName="Bd" Value="{DynamicResource ToolBarButtonHover}"/> 
                              <Setter Property="Foreground" Value="{DynamicResource ToolBarTextFontHighlightColor}"/> 
                          </Trigger> 
                          <Trigger Property="IsEnabled" Value="false"> 
                              <Setter Property="Foreground" Value="{DynamicResource {x:Static SystemColors.GrayTextBrushKey}}"/> 
                          </Trigger> 
                      </ControlTemplate.Triggers> 
                  </ControlTemplate> 
              </Setter.Value> 
          </Setter> 
      </Style> 
        <Style x:Key="ToolBarSplitButtonStyle" TargetType="{x:Type control:SplitButton}" BasedOn="{StaticResource ToolBarButtonBaseStyle}" > 
      <Setter Property="HorizontalAlignment" Value="Stretch"/> 
      <Setter Property="VerticalAlignment" Value="Stretch"/> 
      <Setter Property="HorizontalContentAlignment" Value="Stretch"/> 
      <Setter Property="VerticalContentAlignment" Value="Center"/> 
      <Setter Property="Height" Value="42"/> 
        <Setter Property="FocusVisualStyle" Value="{DynamicResource MainToolBarFocusVisual}"/> 
      <Setter Property="Template"> 
        <Setter.Value> 
          <ControlTemplate TargetType="{x:Type control:SplitButton}"> 
            <Border SnapsToDevicePixels="True" Background="{TemplateBinding Background}" BorderBrush="{TemplateBinding BorderBrush}" BorderThickness="{TemplateBinding BorderThickness}"> 
              <StackPanel Orientation="Horizontal" Margin="0,0,0,0"> 
                <Button x:Name="PART_Button"  Margin="0,0,0,0" Style="{DynamicResource ButtonStyle}" AutomationProperties.Name="{Binding Path=(AutomationProperties.Name), RelativeSource={RelativeSource Mode=FindAncestor, AncestorType={x:Type control:SplitButton}}}" FocusVisualStyle="{DynamicResource MainToolBarFocusVisual}" > 
                  <StackPanel Orientation="Horizontal"> 
                    <Image x:Name="Icon"  Margin="7,0,7,0" VerticalAlignment="Center" MaxWidth="16" MaxHeight="16" Source="{TemplateBinding Image}"/> 
                    <ContentPresenter x:Name="ToolBarSplitButtonContent" Margin="0,7,7,7" HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}" SnapsToDevicePixels="{TemplateBinding SnapsToDevicePixels}" VerticalAlignment="{TemplateBinding VerticalContentAlignment}"/> 
                  </StackPanel> 
                </Button> 
                <Separator Style="{DynamicResource VerticalSeparatorStyle}" Height="1" Width="16" Background="{DynamicResource SeparatorBrush}" Margin="0,0,0,0"/> 
                <Border x:Name="SplitDropDown"> 
                  <Path x:Name="DownArrow" Style="{DynamicResource DownArrowGeometryStyle}" Margin="4,4,4,0"/> 
                </Border> 
              </StackPanel> 
            </Border> 
            <ControlTemplate.Triggers> 
              <Trigger Property="Image" Value="{x:Null}"> 
                <Setter TargetName="Icon" Property="Visibility" Value="Collapsed"/> 
                <Setter TargetName="ToolBarSplitButtonContent" Property="Margin" Value="7,7,7,7"/> 
              </Trigger> 
              <Trigger Property="Text" Value="{x:Null}"> 
                <Setter TargetName="ToolBarSplitButtonContent" Property="Margin" Value="0,0,0,0"/> 
              </Trigger> 
              <Trigger SourceName="PART_Button" Property="IsMouseOver" Value="True"> 
                <Setter Property="Background" Value="Transparent" TargetName="SplitDropDown"/> 
                <Setter Property="Background" Value="{DynamicResource ToolBarButtonHover}" TargetName="PART_Button"/> 
              </Trigger> 
              <Trigger SourceName="PART_Button" Property="IsKeyboardFocused" Value="True"> 
                <Setter Property="Background" Value="{DynamicResource ToolBarButtonHover}" TargetName="PART_Button"/> 
              </Trigger> 
              <Trigger SourceName="SplitDropDown" Property="IsMouseOver" Value="True"> 
                <Setter Property="Background" Value="{DynamicResource ToolBarButtonHover}" TargetName="SplitDropDown"/> 
                <Setter Property="Background" Value="Transparent" TargetName="PART_Button"/> 
              </Trigger> 
              <Trigger Property="IsChecked" Value="True"> 
                <Setter Property="Background" Value="{DynamicResource ToolBarButtonHover}"/> 
              </Trigger> 
              <Trigger Property="IsKeyboardFocused" Value="True"> 
                <Setter Property="Background" Value="{DynamicResource ToolBarButtonHover}"/> 
              </Trigger> 
              <MultiTrigger> 
                <MultiTrigger.Conditions> 
                  <Condition Property="IsMouseOver" Value="True"/> 
                  <Condition Property="IsChecked" Value="True"/> 
                </MultiTrigger.Conditions> 
                <Setter Property="Background" Value="{DynamicResource ToolBarButtonHover}"/> 
              </MultiTrigger> 
              <MultiTrigger> 
                <MultiTrigger.Conditions> 
                  <Condition Property="IsKeyboardFocused" Value="True"/> 
                  <Condition Property="IsChecked" Value="True"/> 
                </MultiTrigger.Conditions> 
                <Setter Property="Background" Value="{DynamicResource ToolBarButtonHover}"/> 
              </MultiTrigger> 
              <Trigger Property="IsPressed" Value="True"> 
                <Setter Property="Background" Value="{DynamicResource ToolBarButtonHover}"/> 
              </Trigger> 
              <Trigger Property="IsEnabled" Value="False"> 
                <Setter Property="Foreground" Value="{DynamicResource {x:Static SystemColors.GrayTextBrushKey}}"/> 
              </Trigger> 
            </ControlTemplate.Triggers> 
          </ControlTemplate> 
        </Setter.Value> 
      </Setter> 
    </Style> 
  </ResourceDictionary> 
  ```
  
**Sample 2:**
The sample XAML that defines defines <xref:System.Windows.ResourceDictionary> of <xref:System.Windows.Style> and <xref:System.Windows.Media.Brush> resources demonstrates customizing the **Main** toolbar.

> [!NOTE]
> You can find this sample XAML styles in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] - Unified Interface sample package.

  ```XAML
  <ResourceDictionary xmlns="https://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="https://schemas.microsoft.com/winfx/2006/xaml"
  xmlns:usd="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics"
  xmlns:controlStyles="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics.Controls.Styles;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics"
  xmlns:usdPanelLayouts="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics.PanelLayouts;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics"
  xmlns:themes="clr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Luna"
  xmlns:control="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics.Controls;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics">

    <Style x:Key="ToolBarMainPanelBorderStyle" TargetType="{x:Type Border}">
          <Setter Property="Margin" Value="0,0,0,0"/>
          <Setter Property="CornerRadius" Value="3,3,3,3"/>
          <Setter Property="KeyboardNavigation.TabNavigation" Value="Continue"/>
          <Style.Triggers>
              <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
                  <Setter Property="CornerRadius" Value="0,0,0,0"/>
              </DataTrigger>
          </Style.Triggers>
      </Style>

  <Style x:Key="ToolBarThumbStyle" TargetType="{x:Type Thumb}">
          <Setter Property="Template">
              <Setter.Value>
                  <ControlTemplate TargetType="{x:Type Thumb}">
                      <Border Background="Transparent" Padding="{TemplateBinding Padding}" SnapsToDevicePixels="True">
                          <Rectangle>
                              <Rectangle.Fill>
                                  <DrawingBrush TileMode="Tile" Viewbox="0,0,4,4" Viewport="0,0,4,4" ViewportUnits="Absolute" ViewboxUnits="Absolute">
                                      <DrawingBrush.Drawing>
                                          <DrawingGroup>
                                              <GeometryDrawing Brush="White" Geometry="M 1 1 L 1 3 L 3 3 L 3 1 z"/>
                                              <GeometryDrawing Brush="{DynamicResource ToolBarGripper}" Geometry="M 0 0 L 0 2 L 2 2 L 2 0 z"/>
                                          </DrawingGroup>
                                      </DrawingBrush.Drawing>
                                  </DrawingBrush>
                              </Rectangle.Fill>
                          </Rectangle>
                      </Border>
                      <ControlTemplate.Triggers>
                          <Trigger Property="IsMouseOver" Value="true">
                              <Setter Property="Cursor" Value="SizeAll"/>
                          </Trigger>
                      </ControlTemplate.Triggers>
                  </ControlTemplate>
              </Setter.Value>
          </Setter>
      </Style>

  <Style x:Key="ToolBarHorizontalOverflowButtonStyle" TargetType="{x:Type ToggleButton}">
          <Setter Property="Background" Value="Transparent"/>
          <Setter Property="MinHeight" Value="0"/>
          <Setter Property="MinWidth" Value="0"/>
          <Setter Property="KeyboardNavigation.TabNavigation" Value="Continue"/>
          <Setter Property="Template">
              <Setter.Value>
                  <ControlTemplate TargetType="{x:Type ToggleButton}">
                      <Border x:Name="Bd" Background="Transparent" CornerRadius="0" SnapsToDevicePixels="true">
                          <Image Source="{DynamicResource ImageMoreToolBarButtons}" Margin="7,5,7,5" Width="16" Height="16" VerticalAlignment="Bottom" HorizontalAlignment="Right"
                                    AutomationProperties.Name="More Menu"></Image>
                      </Border>
                      <ControlTemplate.Triggers>
                          <Trigger Property="IsMouseOver" Value="true">
                              <Setter Property="Background" TargetName="Bd" Value="{DynamicResource USDTabBackgroundBrush}"/>
                          </Trigger>
                          <Trigger Property="IsKeyboardFocused" Value="true">
                              <Setter Property="Background" TargetName="Bd" Value="{DynamicResource USDTabBackgroundBrush}"/>
                              <Setter Property="KeyboardNavigation.TabNavigation" Value="Continue"/>
                          </Trigger>
                          <Trigger Property="IsEnabled" Value="false">
                              <Setter Property="Foreground" Value="{DynamicResource ToolBarGripper}"/>
                          </Trigger>
                      </ControlTemplate.Triggers>
                  </ControlTemplate>
              </Setter.Value>
          </Setter>
          <Style.Triggers>
              <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
                  <Setter Property="Background" Value="Transparent"/>
              </DataTrigger>
          </Style.Triggers>
      </Style>


      <Style x:Key="ToolBarVerticalOverflowButtonStyle" TargetType="{x:Type ToggleButton}">
          <Setter Property="Background" Value="{DynamicResource NormalBrush}"/>
          <Setter Property="MinHeight" Value="0"/>
          <Setter Property="MinWidth" Value="0"/>
          <Setter Property="KeyboardNavigation.TabNavigation" Value="Continue"/>
          <Setter Property="KeyboardNavigation.DirectionalNavigation" Value="Continue"/>
          <Setter Property="Template">
              <Setter.Value>
                  <ControlTemplate TargetType="{x:Type ToggleButton}">
                      <Border x:Name="Bd" Background="Transparent" CornerRadius="0" SnapsToDevicePixels="true">
                          <Image Source="{DynamicResource ImageMoreToolBarButtons}" Margin="7,5,7,5" Width="16" Height="16" VerticalAlignment="Bottom" HorizontalAlignment="Right"
                                    AutomationProperties.Name="More Menu"></Image>
                      </Border>
                      <ControlTemplate.Triggers>
                          <Trigger Property="IsMouseOver" Value="true">
                              <Setter Property="Background" TargetName="Bd" Value="{DynamicResource USDTabBackgroundBrush}"/>
                          </Trigger>
                          <Trigger Property="IsKeyboardFocused" Value="true">
                              <Setter Property="Background" TargetName="Bd" Value="{DynamicResource USDTabBackgroundBrush}"/>
                              <Setter Property="KeyboardNavigation.TabNavigation" Value="Continue"/>
                          </Trigger>
                          <Trigger Property="IsEnabled" Value="false">
                              <Setter Property="Foreground" Value="{DynamicResource ToolBarGripper}"/>
                          </Trigger>
                      </ControlTemplate.Triggers>
                  </ControlTemplate>
              </Setter.Value>
          </Setter>
          <Style.Triggers>
              <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
                  <Setter Property="Background" Value="Transparent"/>
              </DataTrigger>
          </Style.Triggers>
      </Style>

  <Style TargetType="{x:Type ToolBar}">
          <Setter Property="Background" Value="Transparent"/>
          <Setter Property="KeyboardNavigation.TabNavigation" Value="Local"/>
          <Setter Property="KeyboardNavigation.DirectionalNavigation" Value="Continue"/>
          <Setter Property="Template">
              <Setter.Value>
                  <ControlTemplate TargetType="{x:Type ToolBar}">
                      <Grid x:Name="Grid" Margin="0,0,0,0" SnapsToDevicePixels="true" Height="42">
                          <Grid x:Name="OverflowGrid" HorizontalAlignment="Right" Margin="0,0,-11,0">
                              <ToggleButton x:Name="OverflowButton" ClickMode="Press" FocusVisualStyle="{x:Null}" IsChecked="{Binding IsOverflowOpen, Mode=TwoWay, RelativeSource={RelativeSource TemplatedParent}}" 
                                            IsEnabled="{TemplateBinding HasOverflowItems}" Style="{StaticResource ToolBarHorizontalOverflowButtonStyle}" Visibility="Collapsed"
                                            Margin="0,0,0,5">
                              </ToggleButton>
                              <Popup x:Name="OverflowPopup" AllowsTransparency="true" Focusable="True" IsOpen="{Binding IsOverflowOpen, RelativeSource={RelativeSource TemplatedParent}}" PopupAnimation="{DynamicResource {x:Static SystemParameters.ComboBoxPopupAnimationKey}}" Placement="Bottom" StaysOpen="false">
                                  <themes:SystemDropShadowChrome x:Name="Shdw" Color="Transparent">
                                      <Border x:Name="ToolBarSubMenuBorder" BorderBrush="{DynamicResource ToolBarMenuBorder}" BorderThickness="1" Background="{DynamicResource ToolBarSubMenuBackground}" RenderOptions.ClearTypeHint="Enabled">
                                          <ToolBarOverflowPanel x:Name="PART_ToolBarOverflowPanel" KeyboardNavigation.DirectionalNavigation="Continue" FocusVisualStyle="{x:Null}" Focusable="true" SnapsToDevicePixels="{TemplateBinding SnapsToDevicePixels}" KeyboardNavigation.TabNavigation="Cycle" WrapWidth="200"/>
                                      </Border>
                                  </themes:SystemDropShadowChrome>
                              </Popup>
                          </Grid>
                          <Border x:Name="MainPanelBorder" BorderBrush="{TemplateBinding BorderBrush}" BorderThickness="{TemplateBinding BorderThickness}" Background="{TemplateBinding Background}" Padding="{TemplateBinding Padding}" Style="{StaticResource ToolBarMainPanelBorderStyle}">
                              <DockPanel KeyboardNavigation.TabIndex="1" KeyboardNavigation.TabNavigation="Local">
                                  <Thumb x:Name="ToolBarThumb" Margin="-3,-1,0,0" Padding="6,5,1,6" Style="{StaticResource ToolBarThumbStyle}"/>
                                  <ContentPresenter x:Name="ToolBarHeader" ContentSource="Header" HorizontalAlignment="Center" Margin="4,0,4,0" SnapsToDevicePixels="{TemplateBinding SnapsToDevicePixels}" VerticalAlignment="Center"/>
                                  <ToolBarPanel x:Name="PART_ToolBarPanel" IsItemsHost="true" Margin="0" SnapsToDevicePixels="{TemplateBinding SnapsToDevicePixels}"/>
                              </DockPanel>
                          </Border>
                      </Grid>
                      <ControlTemplate.Triggers>
                          <Trigger Property="HasOverflowItems" Value="true">
                              <Setter Property="Visibility" TargetName="OverflowButton" Value="Visible"/>
                          </Trigger>
                          <Trigger Property="IsOverflowOpen" Value="true">
                              <Setter Property="IsEnabled" TargetName="ToolBarThumb" Value="false"/>
                          </Trigger>
                          <Trigger Property="Header" Value="{x:Null}">
                              <Setter Property="Visibility" TargetName="ToolBarHeader" Value="Collapsed"/>
                          </Trigger>
                          <Trigger Property="ToolBarTray.IsLocked" Value="true">
                              <Setter Property="Visibility" TargetName="ToolBarThumb" Value="Collapsed"/>
                          </Trigger>
                          <Trigger Property="HasDropShadow" SourceName="OverflowPopup" Value="true">
                              <Setter Property="Margin" TargetName="Shdw" Value="0,0,5,5"/>
                              <Setter Property="SnapsToDevicePixels" TargetName="Shdw" Value="true"/>
                              <Setter Property="Color" TargetName="Shdw" Value="#71000000"/>
                          </Trigger>
                          <Trigger Property="Orientation" Value="Vertical">
                              <Setter Property="Margin" TargetName="Grid" Value="1,3,1,1"/>
                              <Setter Property="Style" TargetName="OverflowButton" Value="{StaticResource ToolBarVerticalOverflowButtonStyle}"/>
                              <Setter Property="Height" TargetName="ToolBarThumb" Value="10"/>
                              <Setter Property="Width" TargetName="ToolBarThumb" Value="Auto"/>
                              <Setter Property="Margin" TargetName="ToolBarThumb" Value="-1,-3,0,0"/>
                              <Setter Property="Padding" TargetName="ToolBarThumb" Value="5,6,6,1"/>
                              <Setter Property="Margin" TargetName="ToolBarHeader" Value="0,0,0,4"/>
                              <Setter Property="Margin" TargetName="PART_ToolBarPanel" Value="1,0,2,2"/>
                              <Setter Property="DockPanel.Dock" TargetName="ToolBarThumb" Value="Top"/>
                              <Setter Property="DockPanel.Dock" TargetName="ToolBarHeader" Value="Top"/>
                              <Setter Property="HorizontalAlignment" TargetName="OverflowGrid" Value="Stretch"/>
                              <Setter Property="VerticalAlignment" TargetName="OverflowGrid" Value="Bottom"/>
                              <Setter Property="Placement" TargetName="OverflowPopup" Value="Right"/>
                              <Setter Property="Margin" TargetName="MainPanelBorder" Value="0,0,0,11"/>
                              <Setter Property="Background" Value="Transparent"/>
                              <Setter Property="KeyboardNavigation.TabNavigation" Value="Local"/>
                              <Setter Property="KeyboardNavigation.DirectionalNavigation" Value="Continue"/>
                          </Trigger>
                          <Trigger Property="IsEnabled" Value="false">
                              <Setter Property="Foreground" Value="{DynamicResource {x:Static SystemColors.GrayTextBrushKey}}"/>
                          </Trigger>
                      </ControlTemplate.Triggers>
                  </ControlTemplate>
              </Setter.Value>
          </Setter>
          <Style.Triggers>
              <DataTrigger Binding="{Binding Source={x:Static SystemParameters.HighContrast}}" Value="true">
                  <Setter Property="Background" Value="Transparent"/>
              </DataTrigger>
          </Style.Triggers>
      </Style>

  <Style x:Key="ToolBarButtonBaseStyle">
          <Setter Property="Control.BorderThickness" Value="0"/>
          <Setter Property="Control.Padding" Value="0"/>
          <Setter Property="Control.Background" Value="Transparent"/>
          <Setter Property="Control.BorderBrush" Value="Transparent"/>
          <Setter Property="Control.Foreground" Value="{DynamicResource ToolBarFontColor}"/>
          <Setter Property="Control.FontFamily" Value="Segoe UI"/>
          <Setter Property="Control.FontSize" Value="12"/>
      </Style>

  <Style x:Key="MainToolBarFocusVisual">
      <Setter Property="Control.Template">
        <Setter.Value>
          <ControlTemplate>
            <Rectangle SnapsToDevicePixels="true" Stroke="White"
                    StrokeDashArray="1 2" StrokeThickness="1"/>
          </ControlTemplate>
        </Setter.Value>
      </Setter>
    </Style>

  <Style x:Key="ToolbarButtonTemplate" TargetType="{x:Type control:ToolbarButton}" BasedOn="{StaticResource ToolBarButtonBaseStyle}">
          <Setter Property="HorizontalContentAlignment" Value="Center"/>
          <Setter Property="VerticalContentAlignment" Value="Center"/>
          <Setter Property="VerticalAlignment" Value="Center"/>
          <Setter Property="FontFamily" Value="Segoe UI"/>
          <Setter Property="FontSize" Value="14"/>
          <Setter Property="FocusVisualStyle" Value="{DynamicResource MainToolBarFocusVisual}"/>
          <Setter Property="Template">
              <Setter.Value>
                  <ControlTemplate TargetType="{x:Type control:ToolbarButton}">
                      <Border x:Name="Bd" Height="42"  BorderBrush="{TemplateBinding BorderBrush}" BorderThickness="{TemplateBinding BorderThickness}" Background="{TemplateBinding Background}" Padding="{TemplateBinding Padding}" SnapsToDevicePixels="true">
                          <StackPanel x:Name="ToolBarButtonStackPanel"  Orientation="Horizontal" Margin="14,0,14,0">
                              <Image Margin="0,0,7,0" x:Name="Icon" VerticalAlignment="Center" MaxWidth="16" MaxHeight="16" Source="{TemplateBinding Image}"/>
                              <ContentPresenter x:Name="ToolBarButtonContentPresenter" Margin="0,7,0,7" HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}" SnapsToDevicePixels="{TemplateBinding SnapsToDevicePixels}" VerticalAlignment="{TemplateBinding VerticalContentAlignment}"/>
                          </StackPanel>
                      </Border>
                      <ControlTemplate.Triggers>
                          <Trigger Property="Text" Value="{x:Null}">
                              <Setter TargetName="Icon" Property="Margin" Value="0,0,0,0"/>
                          </Trigger>
                          <Trigger Property="Image" Value="{x:Null}">
                              <Setter TargetName="Icon" Property="Visibility" Value="Collapsed"/>
                          </Trigger>
                          <Trigger Property="IsMouseOver" Value="true">
                              <Setter Property="Background" TargetName="Bd" Value="{DynamicResource ToolBarButtonHover}"/>
                              <Setter Property="Foreground" Value="{DynamicResource ToolBarTextFontHighlightColor}"/>
                          </Trigger>
                          <Trigger Property="IsKeyboardFocused" Value="true">
                              <Setter Property="Background" TargetName="Bd" Value="{DynamicResource ToolBarButtonHover}"/>
                              <Setter Property="Foreground" Value="{DynamicResource ToolBarTextFontHighlightColor}"/>
                          </Trigger>
                          <Trigger Property="IsPressed" Value="true">
                              <Setter Property="Background" TargetName="Bd" Value="{DynamicResource ToolBarButtonPressed}"/>
                              <Setter Property="Foreground" Value="{DynamicResource ToolBarButtonHover}"/>
                          </Trigger>
                          <Trigger Property="IsEnabled" Value="false">
                              <Setter Property="Foreground" Value="{DynamicResource {x:Static SystemColors.GrayTextBrushKey}}"/>
                          </Trigger>
                      </ControlTemplate.Triggers>
                  </ControlTemplate>
              </Setter.Value>
          </Setter>
      </Style>
  <Style x:Key="ToolBarDropDownButtonStyle" TargetType="{x:Type control:DropDownButton}" BasedOn="{StaticResource ToolBarButtonBaseStyle}">
          <Setter Property="HorizontalAlignment" Value="Stretch"/>
          <Setter Property="VerticalAlignment" Value="Stretch"/>
          <Setter Property="HorizontalContentAlignment" Value="Stretch"/>
          <Setter Property="VerticalContentAlignment" Value="Center"/>
          <Setter Property="FontFamily" Value="Segoe UI"/>
          <Setter Property="FontSize" Value="14"/>
          <Setter Property="FocusVisualStyle" Value="{DynamicResource MainToolBarFocusVisual}"/>
          <Setter Property="Template">
              <Setter.Value>
                  <ControlTemplate TargetType="{x:Type control:DropDownButton}">
                      <Border SnapsToDevicePixels="True" Background="{TemplateBinding Background}" BorderBrush="{TemplateBinding BorderBrush}" BorderThickness="{TemplateBinding BorderThickness}">
                          <!--<Label>-->
                          <StackPanel Orientation="Horizontal" Margin="14,0,14,0">
                              <Image Margin="0,0,7,0" x:Name="Icon" VerticalAlignment="Center" Width="16" Height="16" Source="{TemplateBinding Image}"/>
                              <ContentPresenter Margin="{TemplateBinding Margin}" HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}" SnapsToDevicePixels="{TemplateBinding SnapsToDevicePixels}" VerticalAlignment="{TemplateBinding VerticalContentAlignment}"/>
                              <Path x:Name="DownArrow" Style="{DynamicResource DownArrowGeometryStyle}" Margin="7,4,0,0"/>
                          </StackPanel>
                          <!--</Label>-->
                      </Border>
                      <ControlTemplate.Triggers>
                          <Trigger Property="Text" Value="{x:Null}">
                              <Setter TargetName="Icon" Property="Margin" Value="0,0,0,0"/>
                          </Trigger>
                          <Trigger Property="Image" Value="{x:Null}">
                              <Setter TargetName="Icon" Property="Visibility" Value="Collapsed"/>
                          </Trigger>
                          <Trigger Property="IsChecked" Value="True">
                              <Setter Property="Background" Value="White"/>
                              <Setter Property="Foreground" Value="{DynamicResource ToolBarButtonHover}"/>
                              <Setter TargetName="DownArrow" Property="Stroke" Value="{DynamicResource ToolBarButtonHover}" />
                          </Trigger>
                          <Trigger Property="IsMouseOver" Value="True">
                              <Setter Property="Background" Value="{DynamicResource ToolBarButtonHover}"/>
                              <Setter Property="Foreground" Value="{DynamicResource ToolBarTextFontHighlightColor}"/>
                              <Setter TargetName="DownArrow" Property="Stroke" Value="{DynamicResource ToolBarTextFontHighlightColor}" />
                          </Trigger>
                          <Trigger Property="IsKeyboardFocused" Value="True">
                              <Setter Property="Background" Value="{DynamicResource ToolBarButtonHover}"/>
                              <Setter Property="Foreground" Value="{DynamicResource ToolBarTextFontHighlightColor}"/>
                              <Setter TargetName="DownArrow" Property="Stroke" Value="{DynamicResource ToolBarTextFontHighlightColor}" />
                          </Trigger>

                          <MultiTrigger>
                              <MultiTrigger.Conditions>
                                  <Condition Property="IsMouseOver" Value="True"/>
                                  <Condition Property="IsChecked" Value="True"/>
                              </MultiTrigger.Conditions>
                              <Setter Property="Background" Value="{DynamicResource ToolBarSplitButtonSelectedBrush}"/>
                              <Setter Property="Foreground" Value="{DynamicResource ToolBarTextFontHighlightColor}"/>
                              <Setter TargetName="DownArrow" Property="Stroke" Value="{DynamicResource ToolBarTextFontHighlightColor}" />
                          </MultiTrigger>
                          <MultiTrigger>
                              <MultiTrigger.Conditions>
                                  <Condition Property="IsKeyboardFocused" Value="True"/>
                                  <Condition Property="IsChecked" Value="True"/>
                              </MultiTrigger.Conditions>
                              <Setter Property="Background" Value="White"/>
                              <Setter Property="Foreground" Value="{DynamicResource ToolBarButtonHover}"/>
                              <Setter TargetName="DownArrow" Property="Stroke" Value="{DynamicResource ToolBarButtonHover}" />
                          </MultiTrigger>
                          <Trigger Property="IsPressed" Value="True">
                              <Setter Property="Background" Value="White"/>
                              <Setter Property="Foreground" Value="{DynamicResource ToolBarButtonHover}"/>
                              <Setter TargetName="DownArrow" Property="Stroke" Value="{DynamicResource ToolBarButtonHover}"/>

                          </Trigger>
                          <Trigger Property="IsEnabled" Value="False">
                              <Setter Property="Foreground" Value="{DynamicResource {x:Static SystemColors.GrayTextBrushKey}}"/>
                          </Trigger>
                      </ControlTemplate.Triggers>
                  </ControlTemplate>
              </Setter.Value>
          </Setter>
      </Style>
  </ResourceDictionary>
  ```
  
## See also  
 [Toolbars in Unified Service Desk](../unified-service-desk/toolbars-unified-service-desk.md)

 [Overview of configuring agent application](../unified-service-desk/configure-agent-application-unified-service-desk.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]