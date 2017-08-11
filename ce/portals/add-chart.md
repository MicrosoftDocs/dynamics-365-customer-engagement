---
title: "Add chart to a web page in a portal in Dynamics 365 | MicrosoftDocs"
description: "Instructions to add Dynamics 365 chart to a web page in portal."
ms.custom: ""
ms.date: 08/11/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 3631007F-1C4E-4F82-9881-22F0606FDA36
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---

# Add a [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] chart to a web page in portal

A chart is added to a web page using a [Liquid tag](liquid-tags.md) named "chart". You can add the chart Liquid tag in the **Copy** field on a Web Page or in the **Source** field on a [Web Template](store-content-web-template.md).
 
For example, {% chart id:"EE3C733D-5693-DE11-97D4-00155DA3B01E" %}

![Dynamics 365 chart example](media/dynamics365-chart-example.png "Dynamics 365 chart example")

You may also specify the ID of a view (saved query) to filter the query. For example:

<!—Leads by Source – Open Leads -->

{% chart id:"EE3C733D-5693-DE11-97D4-00155DA3B01E" viewid:"00000000-0000-0000-00AA-000010001006" %}

## Get the ID of a chart

1.	Go to the target entity, for example, **Sales** > **Leads**.
2.	Expand the **Charts** area.
3.	Select the desired chart.
4.	Click the **More Commands** (…) button and select **Export Chart**.

    ![Export a Dynamics 365 chart](media/export-dynamics365-chart.png "Export a Dynamics 365 chart")

5. Open XML file of the exported chart in a text editor.
6. Copy the value of the \<visualizationid\> tag.

    ![Get chartid for a Dynamics 365 chart](media/dynamics365-chart-chartid.png "Get chartid for a Dynamics 365 chart")

7. Paste the visualizationid value into your Liquid chart tag declaration for the chart id parameter, for example:

    {% chart id:"EE3C733D-5693-DE11-97D4-00155DA3B01E" %}.

## Get the ID of a view

You must open the view editor to get the view ID to be used with the Liquid chart tag.
 
1.	Go to the target entity, for example, **Sales** > **Leads**.
2.	Select the desired view from the view dropdown header.
3.	Select **View** from the toolbar. The View window opens.

    ![View the leads in the view editor](media/dynamics365-chart-view.png "View the leads in the view editor")

4. Copy the **id** value from the View window's URL.

    ![Get view id from the view editor](media/dynamics365-chart-viewid.png "Get view id from the view editor")

5. Paste this id into your Liquid chart tag declaration for the viewid parameter, for example:

    <!—Leads by Source – Open Leads -->

    {% chart id:"EE3C733D-5693-DE11-97D4-00155DA3B01E" viewid:"00000000-0000-0000-00AA-000010001006" %}

## Entity permission requirement

Read privilege is asserted for the target entity being queried in the chart. For anonymous or authenticated users to be able to view the chart, you must ensure that the appropriate [Entity Permission](assign-entity-permissions.md) record(s) are created and assigned to applicable [Web Roles](create-web-roles.md). 
 
If permission is not granted, the user will see an access denied message.

## Unsupported charts and chart types

The following [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] chart types are currently not supported in portals.
- Doughnut
- Tag

The following [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] charts are currently not supported in portals.

| Chart Name                              | Chart ID                             | Entity Type      |
|-----------------------------------------|--------------------------------------|------------------|
| Accounts by Owner - Tag Chart           | be178262-6142-4b41-85b7-4ccedc62cfd9 | account          |
| Activities by Owner - Tag Chart         | c83b331e-87c7-488c-b8e7-89a6098ea102 | activitypointer  |
| Activities by Priority - Doughnut Chart | d3f6c1eb-2e4b-428b-8949-682a311ae057 | activitypointer  |
| Contacts by Account                     | 2ff3ebea-6310-4dde-b3a1-e1144ea42b7b | contact          |
| Contacts by Country                     | ea89e2ad-2602-4333-8724-aa5775d66b77 | contact          |
| Contacts by Preferred Contact Method    | 751b7456-308e-4568-a3a9-47135aae833a | contact          |
| Goal Progress (Count)                   | a93b8f7b-9c68-df11-ae90-00155d2e3002 | goal             |
| Goal Progress (Money)                   | aec6d51c-ea67-df11-ae90-00155d2e3002 | goal             |
| Today's Target Vs. Actuals (Count)      | 1b697c8e-9a6f-df11-986c-00155d2e3002 | goal             |
| Today's Target Vs. Actuals (Money)      | 1e697c8e-9a6f-df11-986c-00155d2e3002 | goal             |
| Cases By Account                        | 38872e4f-ac99-e511-80da-00155dc1b253 | incident         |
| Cases By Priority                       | 0f0fb995-9d6f-453c-b26d-8f443e42e676 | incident         |
| Cases By Product                        | 17c3f166-5b22-4476-819b-b05da2e8d24f | incident         |
| Articles expiring this month by owner   | 47d696ad-7c3b-e511-80d1-00155db10d2b | knowledgearticle |
| By Owner                                | 330068fd-833b-e511-80d1-00155db10d2b | knowledgearticle |
| By Subject                              | bcd3f9a5-913b-e511-80d1-00155db10d2b | knowledgearticle | 
| | |