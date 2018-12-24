---
title: "Create forms to define layout and behavior of the notification"
description: "Learn how to create forms to define layout and behavior of the alert notification in Omni-channel Engagement Hub."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: 5ea71717-26e0-4e30-b2f8-629626132341
ms.custom: 
---
# Step 1: Create forms to define layout and behavior of the notification

1.  Sign in to Dynamics 365.

2.  Go to **Settings** &gt; **Unified Service Desk**.

3.  Select **Forms** and select **+ New**.

4.  In the new form, specify the details.

  <table>
    <tr>
        <th>Field</th>
        <th>Value</th>
    </tr>
    <tr>
        <td>Name</td>
        <td>SimpleChatRequestPopupForm</td>
    </tr>
    <tr>
        <td>Order</td>
        <td>50</td>
    </tr>
    <tr>
        <td>Markup</td>
        <td><Border xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:CCA="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics"
        xmlns:Converters="clr-namespace:USDConverters;assembly=USDConverters" xmlns:local="clr-namespace:Microsoft.Crm.UnifiedServiceDesk.Dynamics;assembly=Microsoft.Crm.UnifiedServiceDesk.Dynamics" xmlns:System="clr-namespace:System;assembly=mscorlib">
    <Grid Height="auto" Width="280" Background="#333333">
        <Grid.Resources>
            <System:String x:Key="switchvar">[[switchvar]+]</System:String>
            <System:String x:Key="isAccept">[[isAccept]+]</System:String>
            <System:String x:Key="isReject">[[isReject]+]</System:String>
            <System:String x:Key="designation">[[designation]+]</System:String>
            <local:CRMImageConverter x:Key="CRMImageLoader" />
            <Style x:Key="ImageLogo" TargetType="{x:Type Image}">
                <Setter Property="Width" Value="71" />
                <Setter Property="Height" Value="71" />
                <Setter Property="Margin" Value="12,7,0,8" />
            </Style>
            <Style x:Key="ButtonImage" TargetType="{x:Type Image}">
                <Setter Property="Width" Value="16" />
                <Setter Property="Height" Value="16" />
                <Setter Property="HorizontalAlignment" Value="Center" />
                <Setter Property="VerticalAlignment" Value="Center" />
            </Style>
            <Style x:Key="ShowBothButtons" TargetType="Grid">
                <Setter Property="Visibility" Value="Collapsed"/>
                <Style.Triggers>
                    <MultiDataTrigger>
                        <MultiDataTrigger.Conditions>
                            <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
                            <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
                        </MultiDataTrigger.Conditions>
                        <Setter Property="Visibility" Value="Visible"/>
                    </MultiDataTrigger>
                </Style.Triggers>
            </Style>
            <Style x:Key="showDesignation" TargetType="Grid">
                <Setter Property="Visibility" Value="Visible"/>
                <Style.Triggers>
                    <MultiDataTrigger>
                        <MultiDataTrigger.Conditions>
                            <Condition Binding="{Binding Source={StaticResource designation}}" Value="" />
                        </MultiDataTrigger.Conditions>
                        <Setter Property="Visibility" Value="Collapsed"/>
                    </MultiDataTrigger>
                </Style.Triggers>
            </Style>
            <Style x:Key="hideDesignation" TargetType="Grid">
                <Setter Property="Visibility" Value="Collapsed"/>
                <Style.Triggers>
                    <MultiDataTrigger>
                        <MultiDataTrigger.Conditions>
                            <Condition Binding="{Binding Source={StaticResource designation}}" Value="" />
                        </MultiDataTrigger.Conditions>
                        <Setter Property="Visibility" Value="Visible"/>
                    </MultiDataTrigger>
                </Style.Triggers>
            </Style>
            <Style x:Key="showAutoAcceptMesage" TargetType="Grid">
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
            <Style x:Key="hideAutoAcceptMesage" TargetType="Grid">
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
            <Style x:Key="ShowAcceptButton" TargetType="Grid">
                <Setter Property="Visibility" Value="Collapsed"/>
                <Style.Triggers>
                    <MultiDataTrigger>
                        <MultiDataTrigger.Conditions>
                            <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="TRUE" />
                            <Condition Binding="{Binding Source={StaticResource isReject}}" Value="FALSE" />
                        </MultiDataTrigger.Conditions>
                        <Setter Property="Visibility" Value="Visible"/>
                    </MultiDataTrigger>
                </Style.Triggers>
            </Style>
            <Style x:Key="ShowRejectButton" TargetType="Grid">
                <Setter Property="Visibility" Value="Collapsed"/>
                <Style.Triggers>
                    <MultiDataTrigger>
                        <MultiDataTrigger.Conditions>
                            <Condition Binding="{Binding Source={StaticResource isAccept}}" Value="FALSE" />
                            <Condition Binding="{Binding Source={StaticResource isReject}}" Value="TRUE" />
                        </MultiDataTrigger.Conditions>
                        <Setter Property="Visibility" Value="Visible"/>
                    </MultiDataTrigger>
                </Style.Triggers>
            </Style>
            <Style x:Key="AcceptButton" TargetType="Button">
                <Setter Property="OverridesDefaultStyle" Value="False"/>
                <Setter Property="FontSize" Value="14px"/>
                <Setter Property="Background" >
                    <Setter.Value>
                        <LinearGradientBrush StartPoint="0,0" EndPoint="0,1" >
                            <GradientStop Color="#47C21D" Offset="0"/>
                        </LinearGradientBrush>
                    </Setter.Value>
                </Setter>
            </Style>
            <Style x:Key="RejectButton" TargetType="Button">
                <Setter Property="OverridesDefaultStyle" Value="False"/>
                <Setter Property="FontSize" Value="14px"/>
                <Setter Property="Background" >
                    <Setter.Value>
                        <LinearGradientBrush StartPoint="0,0" EndPoint="0,1" >
                            <GradientStop Color="#EA0600" Offset="0"/>
                        </LinearGradientBrush>
                    </Setter.Value>
                </Setter>
            </Style>
        </Grid.Resources>
        <Grid.RowDefinitions>
            <RowDefinition Height="35" />
            <RowDefinition Height="86" />
            <RowDefinition Height="1" />
            <RowDefinition Height="136" />
            <RowDefinition Height="auto" />
        </Grid.RowDefinitions>
        <Grid Style="{StaticResource showAutoAcceptMesage}" Grid.Row="0" Height="35" Background="#000000">
            <Grid.RowDefinitions>
                <RowDefinition Height="35" />
            </Grid.RowDefinitions>
            <StackPanel Margin="14,8,14,8" Orientation="Horizontal" VerticalAlignment="Center" Grid.Row="0">
                <TextBlock Foreground="#FFFFFF" Background="#000000" Text="Accepting chat in " HorizontalAlignment="Left" FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="16" />
                <TextBlock Foreground="#FFFFFF" Background="#000000" Text="{Binding TimeoutProperty}" HorizontalAlignment="Left" FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="16" />
                <TextBlock Foreground="#FFFFFF" Background="#000000" Text=" sec" HorizontalAlignment="Left" FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="16" />
            </StackPanel>
        </Grid>
        <Grid Style="{StaticResource hideAutoAcceptMesage}" Grid.Row="0" Height="35" Background="#000000">
            <Grid.RowDefinitions>
                <RowDefinition Height="35" />
            </Grid.RowDefinitions>
            <StackPanel Margin="14,8,14,8" Orientation="Horizontal" VerticalAlignment="Center" Grid.Row="0">
                <TextBlock Foreground="#FFFFFF" Background="#000000" Text="{Binding TimeoutProperty}" HorizontalAlignment="Left" FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="16" />
                <TextBlock Foreground="#FFFFFF" Background="#000000" Text=" sec remaining" HorizontalAlignment="Left" FontWeight="Regular" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="16" />
            </StackPanel>
        </Grid>
        <Grid Grid.Row="1" Height="auto" >
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="83"/>
                <ColumnDefinition Width="197"/>
            </Grid.ColumnDefinitions>
            <Image Style="{StaticResource ImageLogo}" Source="{Binding Source=new_omni_screenpop_incomingchat_icon, Converter={StaticResource CRMImageLoader}}" Grid.Column="0" />
            <Grid Grid.Column="1" Margin="20,14,14,11" Style="{StaticResource showDesignation}">
                <Grid.RowDefinitions>
                    <RowDefinition Height="auto" />
                    <RowDefinition Height="auto" />
                    <RowDefinition Height="auto" />
                </Grid.RowDefinitions>
                <TextBlock Foreground="#FFFFFF" Grid.Row="0" HorizontalAlignment="Left" Text="Chat Request from" FontWeight="Regular" VerticalAlignment="Center" FontSize="12" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="14" />
                <TextBlock Foreground="#FFFFFF" Grid.Row="1" HorizontalAlignment="Left" FontWeight="SemiBold" Text="[[from]+]" VerticalAlignment="Center" FontSize="18" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="21" />
                <TextBlock Foreground="#FFFFFF" Grid.Row="2" HorizontalAlignment="Left" Text="[[designation]+]" FontWeight="Regular" VerticalAlignment="Center" FontSize="12" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="18" />
            </Grid>
            <Grid Grid.Column="1" Margin="20,21,14,21" Style="{StaticResource hideDesignation}">
                <Grid.RowDefinitions>
                    <RowDefinition Height="auto" />
                    <RowDefinition Height="auto" />
                </Grid.RowDefinitions>
                <TextBlock Foreground="#FFFFFF" Grid.Row="0" HorizontalAlignment="Left" Text="Chat Request from" FontWeight="Regular" VerticalAlignment="Center" FontSize="12" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="14" />
                <TextBlock Foreground="#FFFFFF" Grid.Row="1" HorizontalAlignment="Left" FontWeight="SemiBold" Text="[[from]+]" VerticalAlignment="Center" FontSize="18" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="21" />
            </Grid>
        </Grid>
        <Grid Grid.Row="2" Height="1" Background="#F1F1F1" Opacity="0.13">
            <Grid.RowDefinitions>
                <RowDefinition Height="1" />
            </Grid.RowDefinitions>
        </Grid>
        <Grid Grid.Row="3" Height="auto">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="103"/>
                <ColumnDefinition Width="177"/>
            </Grid.ColumnDefinitions>
            <Grid Grid.Column="0" Margin="14,14,11,7" >
                <Grid.RowDefinitions>
                    <RowDefinition Height="auto" />
                    <RowDefinition Height="auto" />
                    <RowDefinition Height="auto" />
                    <RowDefinition Height="auto" />
                </Grid.RowDefinitions>
                <TextBlock Foreground="#D8D8D8" Grid.Row="0" Margin="0,0,0,11" HorizontalAlignment="Left" Text="Job Title" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="16" FontWeight="Regular" />
                <TextBlock Foreground="#D8D8D8" Grid.Row="1" Margin="0,0,0,11" HorizontalAlignment="Left" Text="Email" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="16" FontWeight="Regular" />
                <TextBlock Foreground="#D8D8D8" Grid.Row="2" Margin="0,0,0,11" HorizontalAlignment="Left" Text="City" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="16" FontWeight="Regular" />
                <TextBlock Foreground="#D8D8D8" Grid.Row="3" Margin="0,0,0,11" HorizontalAlignment="Left" Text="State" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="16" FontWeight="Regular" />
            </Grid>
            <Grid Grid.Column="1" Margin="0,14,14,7">
                <Grid.RowDefinitions>
                    <RowDefinition Height="auto" />
                    <RowDefinition Height="auto" />
                    <RowDefinition Height="auto" />
                    <RowDefinition Height="auto" />
                </Grid.RowDefinitions>
                <TextBlock Foreground="#FFFFFF" Grid.Row="0" Margin="0,0,0,11" HorizontalAlignment="Left" Text="[[jobTitle]+]" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="16" FontWeight="SemiBold" />
                <TextBlock Foreground="#FFFFFF" Grid.Row="1" Margin="0,0,0,11" HorizontalAlignment="Left" Text="[[email]+]" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="16" FontWeight="SemiBold" />
                <TextBlock Foreground="#FFFFFF" Grid.Row="2" Margin="0,0,0,11" HorizontalAlignment="Left" Text="[[city]+]" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="16" FontWeight="SemiBold" />
                <TextBlock Foreground="#FFFFFF" Grid.Row="3" Margin="0,0,0,11" HorizontalAlignment="Left" Text="[[state]+]" VerticalAlignment="Center" FontSize="14" TextTrimming="WordEllipsis" FontFamily="Segoe UI" LineHeight="16" FontWeight="SemiBold" />
            </Grid>
        </Grid>
        <Grid Grid.Row="4" Style="{StaticResource ShowBothButtons}">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="148"/>
                <ColumnDefinition Width="132" />
            </Grid.ColumnDefinitions>
            <Button Grid.Column="0" Margin="14,7,14,14" Height="40" Width="120" Style="{StaticResource AcceptButton}" Foreground="#FFFFFF" Command="CCA:ActionCommands.UIIEvent" CommandParameter="CreateCustomerSessionEvent?cid=[[cid]+]&from=[[from]+]&isUniqueContactRecognized=[[isUniqueContactRecognized]+]&CRMCONTACTID=[[CRMCONTACTID]+]" FontWeight="SemiBold" FontFamily="Segoe UI" >
                <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
                    <Image Grid.Column="0" Style="{StaticResource ButtonImage}" Source="{Binding Source=new_omni_screenpop_accept_icon, Converter={StaticResource CRMImageLoader}}" />
                    <TextBlock Grid.Column="1" Text="Accept" VerticalAlignment="Center" Foreground="#FFFFFF" FontWeight="SemiBold" Margin="5,0,0,0" />
                </StackPanel>
            </Button>
            <Button Grid.Column="1" Margin="0,7,14,14" Height="40" Width="118" Style="{StaticResource RejectButton}" Foreground="#FFFFFF" Command="CCA:ActionCommands.UIIEvent" CommandParameter="IncomingRequestRejected?cid=[[cid]+]&from=[[from]+]" FontWeight="SemiBold" FontFamily="Segoe UI" >
                <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
                    <Image Grid.Column="0" Style="{StaticResource ButtonImage}" Source="{Binding Source=new_omni_screenpop_reject_icon, Converter={StaticResource CRMImageLoader}}" />
                    <TextBlock Grid.Column="1" Text="Reject" VerticalAlignment="Center" Foreground="#FFFFFF" FontWeight="SemiBold" Margin="5,0,0,0" />
                </StackPanel>
            </Button>
        </Grid>
        <Grid Grid.Row="4" Style="{StaticResource ShowAcceptButton}">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>
            <Button Grid.Column="0" Margin="14,14,14,14" Height="40" Width="240" Style="{StaticResource AcceptButton}" Foreground="#FFFFFF" Command="CCA:ActionCommands.UIIEvent" CommandParameter="CreateCustomerSessionEvent?cid=[[cid]+]&from=[[from]+]&isUniqueContactRecognized=[[isUniqueContactRecognized]+]&CRMCONTACTID=[[CRMCONTACTID]+]" FontWeight="SemiBold" FontFamily="Segoe UI" >
                <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
                    <Image Grid.Column="0" Style="{StaticResource ButtonImage}" Source="{Binding Source=new_omni_screenpop_accept_icon, Converter={StaticResource CRMImageLoader}}" />
                    <TextBlock Grid.Column="1" Text="Accept" VerticalAlignment="Center" FontWeight="SemiBold" Foreground="#FFFFFF" Margin="5,0,0,0" />
                </StackPanel>
            </Button>
        </Grid>
        <Grid Grid.Row="4" Style="{StaticResource ShowRejectButton}">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>
            <Button Grid.Column="0" Margin="14,14,14,14" Height="40" Width="240" Style="{StaticResource RejectButton}" Foreground="#FFFFFF" Command="CCA:ActionCommands.UIIEvent" CommandParameter="IncomingRequestRejected?cid=[[cid]+]&from=[[from]+]" FontWeight="SemiBold" FontFamily="Segoe UI" >
                <StackPanel Orientation="Horizontal" VerticalAlignment="Center">
                    <Image Grid.Column="0" Style="{StaticResource ButtonImage}" Source="{Binding Source=new_omni_screenpop_reject_icon, Converter={StaticResource CRMImageLoader}}" />
                    <TextBlock Grid.Column="1" Text="Reject" VerticalAlignment="Center" FontWeight="SemiBold" Foreground="#FFFFFF" Margin="5,0,0,0" />
                </StackPanel>
            </Button>
        </Grid>
    </Grid>
</Border></td>
    </tr>
  </table>

5.  Save the form.

> [!div class="nextstepaction"]
> [Step 2: Create hosted controls](alertnotification-step2-create-hosted-controls.md)

## See also

[Configure notification (Screen pop) for agents](configure-notification-screen-pop-agents.md)

[Step 3: Create events](alertnotification-step3-create-the-events.md)

[Step 4: Create an action call to display the notification](alertnotification-step4-create-action-call-display-notification.md)

[Step 5: Add the action calls to the events](alertnotification-step5-add-action-calls-events.md)

[Step 6: Add the hosted controls, events, and action calls to the agent and supervisor configurations](alertnotification-step6-add-hosted-controls-events-action-callsagent-supervisor-configurations.md)

[Configure toast notification in Unified Service Desk](configure-toast-notification-unified-service-desk.md)