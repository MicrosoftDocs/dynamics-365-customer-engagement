---
title: "Add custom KPIs to intraday insights dashboard | MicrosoftDocs"
description: "How to add custom KPIs to intraday insights dashboard for the Omnichannel for Customer Service."
keywords: ""
author: udaykirang
ms.author: udag
manager: shujoshi
applies_to: 
ms.date: 10/24/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 893b9aeb-67ab-4d20-aa5e-82eb50051bcb
ms.custom: 
---

# Customize KPIs for Intraday insights

To cater to your organizational needs, the Intraday insights allows you to customize KPIs. This allows supervisors to adapt to your organizational parameters that are specifically designed for your organization. Through the Power BI desktop application, you can customize theses KPIs. The customization of KPIs includes:

- [Add custom KPIs](#add-custom-kpis)

- [Edit measures and visuals of existing KPIs](#edit-measures-and-visuals-of-existing-kpis)

## Review prerequisites

Verify the following prerequisites before you add the custom KPIs:

1. Power BI desktop app is installed on your computer.

2. Administrator or equivalent role is assigned to you. 

3. Intraday insights dashboard is configured for your organization. To Learn more, see [Configure to view intraday insights dashboard](configure-intraday-dashboard-supervisor.md)


## Add custom KPIs

You can add the custom KPIs that are specific to your organization to Intraday insights. This allows Intraday insights to be more specific and help supervisors to adhere your organizational requirements. To add custom KPIs, follow these steps:

1. [Review the prerequisites](#review-prerequisites).

2. Open the Power BI desktop application and sign in with your administrator credentials.

3. From the **Home** menu, select **Get Data** > **Power BI datasets**.

   > [!div class=mx-imgBorder]
   > ![Select Power BI datasets](../media/supervisor-admin-custom-kpis-select-pbidatasets.png "Select Power BI datasets")

   The dataset selection dialog box opens.

4. Select **IntradayMonitoring** from the workspace that you have created through configuration ([Configure Power BI workspace in Omnichannel Administration app](configure-intraday-dashboard-supervisor.md#configure-power-bi-workspace-in-omnichannel-administration-app)), and then select **Load**.

   > [!div class=mx-imgBorder]
   > ![Select Intraday insights datasets](../media/supervisor-admin-custom-kpis-select-pbidatasets-intraday.png "Select Intraday insights datasets")

   The fields related to Intraday insights are loaded.

5. From the field category list, select a category to create a measure and then select **More options** (**...**) > **New measure**.

    In this example, we are creating a measure for the field category **AgentAvailability**.

   > [!div class=mx-imgBorder]
   > ![Select Agent Availability field](../media/supervisor-admin-custom-kpis-select-fields.png "Select Agent Availability field")

    A new measure is created for the field.

6. The formula bar appears along the top of the Report canvas, where you can rename your measure and enter a DAX formula.

    In this example, we are adding a measure for calculating the total number hours that an agent is working on a workitem.

    ```
    Total agent work hours = Agent[Average Session Handling Time] + Agent[Average Conversations Per Online Agents]
    ```

    The measure is added.  

7. Select the measure and verify that the measure is working as defined.

   > [!div class=mx-imgBorder]
   > ![Verify created measure](../media/supervisor-admin-custom-kpis-select-verify-measure-formula.png "Verify created measure")

    To learn more about creating measure, see [Create a measures](https://docs.microsoft.com/en-us/power-bi/desktop-tutorial-create-measures#create-a-measure).

8. Add the measure to your report. To learn more, see [Use your measure in the report](https://docs.microsoft.com/en-us/power-bi/desktop-tutorial-create-measures#use-your-measure-in-the-report).

9. Publish the report.

    The custom KPI measure is added to Intraday insights dashboard.

To learn more about how to create custom measures, see [Tutorial: Create your own measures in Power BI Desktop](https://docs.microsoft.com/en-us/power-bi/desktop-tutorial-create-measures).

## Edit measures and visuals of existing KPIs

You can edit the measures and visuals of existing custom and out-of-the-box KPIs to match your organizational requirements. This helps in reducing the effort of adding a new KPI to the Intraday insights. To edit measures of existing KPIs, follow these steps:

1. [Review the prerequisites](#review-prerequisites).

2. Open the Power BI desktop application and sign in with your administrator credentials.

3. From the **Home** menu, select **Get Data** > **Power BI datasets**.

   > [!div class=mx-imgBorder]
   > ![Select Power BI datasets](../media/supervisor-admin-custom-kpis-select-pbidatasets.png "Select Power BI datasets")

   The dataset selection dialog box opens.

4. Select **IntradayMonitoring** from the workspace that you have created through configuration ([Configure Power BI workspace in Omnichannel Administration app](configure-intraday-dashboard-supervisor.md#configure-power-bi-workspace-in-omnichannel-administration-app)), and then select **Load**.

   > [!div class=mx-imgBorder]
   > ![Select Intraday insights datasets](../media/supervisor-admin-custom-kpis-select-pbidatasets-intraday.png "Select Intraday insights datasets")

   The fields related to Intraday insights are loaded.

5. To edit a measure:

    1. From the field category list, select a category and then select the field for which you want to change the measure.  

       > [!NOTE]
       > Fields with measures are preceded with a calculator icon. 

       In this example we are selecting **Total agent work hours** field from **AgentAvailability** category. The details of for the field is displayed including its formula bar.

       > [!div class=mx-imgBorder]
       > ![Select a field to edit the measure](../media/supervisor-admin-custom-kpis-select-field-edit-measure.png "Select a field to edit the measure")

    2. From the formula bar, edit the formula as required.

        To learn more about change visualizations, see [Create and use your own measures](/power-bi/desktop-tutorial-create-measures#create-and-use-your-own-measures).
    
6. To edit a visual:

    1. From the field category list, select a category and then select the field for which you want to change the visual.  

       In this example we are selecting **Agent Handling Time** field from **Session** category. The visual for the field is displayed.

       > [!div class=mx-imgBorder]
       > ![Select a field to change visualization](../media/supervisor-admin-custom-kpis-visual-field-selection.png "Select a field to change visualization")

    2. From the **VISUALIZATIONS** tab, edit the visualizations of the field as required. In this example, we are changing the chart to a pie chart.

       > [!div class=mx-imgBorder]
       > ![Change visualization from bar chart to pie chart](../media/supervisor-admin-custom-kpis-change-bar-to-pie.png "Change visualization from bar chart to pie chart")

        To learn more about change visualizations, see [Add visualizations to a Power BI report](/power-bi/visuals/power-bi-report-add-visualizations-i).

7. Publish the report.

## Reference

The following are the list of tables with entity attributes that are supported in Intraday insights:

- [Agent](#agent)
- [AgentAvailability](#agentavailability)
- [AgentQueueAssociation](#agentqueueassociation)
- [AgentRoleAssociation](#agentroleassociation)
- [Presence](#presence)
- [Queue](#queue)
- [RoleBase](#rolebase)
- [Session](#session)
- [SessionParticipant](#sessionparticipant)
- [WorkItem](#workitem)  
- [WorkStream](#workstream)

### Agent

The Agent consists of the following entity attributes:
- `FirstName`
- `FullName`
- `LastName`
- `MiddleName`
- `msdyn_Capacity`
- `SystemUserId`

To learn more, see [msdyn_systemuser_msdyn_omnichannelqueue Entity Reference](../developer/reference/entities/msdyn_systemuser_msdyn_omnichannelqueue.md).

### AgentAvailability

The AgentAvailability consists of the following entity attributes:

- `AvailableCapacity`
- `BaseStatus`
- `CapacityModifiedOn`
- `Id`
- `ModifiedOn`
- `PresenceId`
- `PresenceModifiedOn`

To learn more about `Id`, see [systemuserid](../developer/reference/entities/msdyn_systemuser_msdyn_omnichannelqueue.md#BKMK_systemuserid).
To learn more about `presenceId`, see [msdyn_presenceId](../developer/reference/entities/msdyn_presence.md#BKMK_msdyn_presenceId).

### AgentQueueAssociation

The AgentQueueAssociation consists of the following entity attributes:

- `msdyn_omnichannelqueueid`
- `msdyn_systemuser_msdyn_omnichannelqueueid`
- `systemuserid`

To learn more, see [msdyn_systemuser_msdyn_omnichannelqueue Entity Reference - Read-only attributes](../developer/reference/entities/msdyn_systemuser_msdyn_omnichannelqueue.md#read-only-attributes).

### AgentRoleAssociation

The AgentRoleAssociation consists of the following entity attributes:

- `RoleId`
- `SystemUserId`
- `SystemUserRoleId`

To learn more about `SystemUserId`, see [systemuserid](../developer/reference/entities/msdyn_systemuser_msdyn_omnichannelqueue.md#BKMK_systemuserid).

### Presence

The Presence table consists of the following entity attributes:

- `msdyn_basepresencestatus`
- `msdyn_name`
- `msdyn_presenceId`
- `msdyn_presencestatustext`

To learn more, see [msdyn_presence Entity Reference - Writable attributes](../developer/reference/entities/msdyn_presence.md#writable-attributes).

### Queue

The Presence table consists of the following entity attributes:

- `msdyn_Isdefaultqueue`
- `msdyn_name`
- `msdyn_omnichannelqueueId`
- `msdyn_Priority`

To learn more, see [msdyn_systemuser_msdyn_omnichannelqueue Entity Reference - Read-only attributes](../developer/reference/entities/msdyn_systemuser_msdyn_omnichannelqueue.md#read-only-attributes).

### RoleBase

The RoleBase table consists of the following entity attributes:

- `Name`
- `RoleId`

To learn more, see [msdyn_systemuser_msdyn_omnichannelqueue Entity Reference](../developer/reference/entities/msdyn_systemuser_msdyn_omnichannelqueue.md).

### Session

The Session table consists of the following entity attributes:

- `Agent Handling Time`
- `Agent Handling Time Seconds`
- `Agent Response Time`
- `Agent Response Time Seconds`
- `Hourly Sessions Created`
- `msdyn_agentacceptedon`
- `msdyn_agentassignedon`
- `msdyn_botengagementmode`
- `msdyn_closurereason`
- `msdyn_liveworkitemid`
- `msdyn_queueassignedon`
- `msdyn_queueid`
- `msdyn_sessionclosedon`
- `msdyn_sessioncreatedon`
- `msdyn_sessionid`
- `msdyn_sessionmodifiedon`
- `msdyn_state`
- `RoundSessionCreatedTime`
- `Session Handling Time`
- `Session Handling Time HHMMSS`
- `Session Handling Time Seconds`
- `Session Wait Time`
- `Session Wait Time Seconds`

To learn more, see [msdyn_ocsession Entity Reference](../developer/reference/entities/msdyn_ocsession.md).

### SessionParticipant

- `Agent Handling Time`
- `AgentName`
- `msdyn_agentid`
- `msdyn_joinedon`
- `msdyn_lefton`
- `msdyn_mode`
- `msdyn_sessionid`
- `msdyn_type`
- `Participation Time`
- `Participation Time HHMMSS`
- `Participation Time Seconds`
- `sessionparticipantid`

To learn more, see [msdyn_sessionparticipant Entity Reference](../developer/reference/entities/msdyn_sessionparticipant.md).

### WorkItem

The WorkItem table consists of the following entity attributes:

- `Hourly conversations created`
- `link`
- `msdyn_activeagentassignedon`
- `msdyn_activeagentid`
- `msdyn_closedon`
- `msdyn_createdon`
- `msdyn_escalationcount`
- `msdyn_initiatedon`
- `msdyn_lastsessionid`
- `msdyn_liveworkstreamid`
- `msdyn_modifiedon`
- `msdyn_ocliveworkitemid`
- `msdyn_queueid`
- `msdyn_startedon`
- `msdyn_statusupdatedon`
- `msdyn_title`
- `msdyn_transfercount`
- `StateCode`
- `StatusCode`
- `oca_botengagementmode`

To learn more, see [msdyn_ocliveworkitem Entity Reference](../developer/reference/entities/msdyn_ocliveworkitem.md).

### WorkStream

The WorkStream table consists of the following entity attributes:

- `msdyn_CapacityRequired`
- `msdyn_liveworkstreamId`
- `msdyn_MaxConcurrentConnection`
- `msdyn_name`
- `msdyn_streamsource`
- `msdyn_workdistributionmode`

To learn more, see [msdyn_liveworkstream Entity Reference](../developer/reference/entities/msdyn_liveworkstream.md).

### See also

[Configure to view intraday insights dashboard](configure-intraday-dashboard-supervisor.md)