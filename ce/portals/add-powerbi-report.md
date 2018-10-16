---
title: "Add a Power BI report or dashboard to a webpage in a portal in Dynamics 365 | MicrosoftDocs"
description: "Instructions to add a Power BI report or dashboard to a webpage in the portal."
ms.custom: 
  - dyn365-portal
ms.date: 10/17/2018
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 79E04266-71C5-4960-AA67-4B4C59F8D777
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: shubhadaj
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Portals
---

# Add a Power BI report or dashboard to a webpage in portal

You can add a Power BI report or dashboard to a webpage in portal by using the [powerbi](dynamics-entity-tags.md#powerbi) Liquid tag. You can add the tag in the **Copy** field on a web page or in the **Source** field on a web template.

For example: 

```
{% powerbi path:"https://app.powerbi.com/view?r=eyJrIjoiNjMzZTY1ZTItMDE2My00NGY5LWIwYmItNjUwMGY5NzEY3IiwidCI6IjU3NGMzZTU2LTQ5MjQtNDAwNC1hZDFhLWQ4NDI3ZTdkYjI0MSiOjZ9" %}
```

> [!NOTE]
> Before adding the secure Power BI report or dashboard to a webpage in portal, you must share it with the required users. More information: [Share Power BI workspace](https://docs.microsoft.com/en-us/power-bi/service-how-to-collaborate-distribute-dashboards-reports#collaborate-with-coworkers-in-an-app-workspace) and [Share Power BI dashboard and report](https://docs.microsoft.com/en-us/power-bi/service-share-dashboards).

## Get the path of a dashboard or report

1.	Sign in to [Power BI](https://powerbi.microsoft.com/).

2.	Open the dashboard or report you want to embed in your portal.

3.	Copy URL from the address bar.

    > [!div class="mx-imgBorder"]
    > ![Get the path of a Power BI dashboard](media/powerbi-dashboard-url.png "Get the path of a Power BI dashboard")

## Get the ID of a dashboard tile

1.	Sign in to [Power BI](https://powerbi.microsoft.com/).

2.	Open the dashboard from which you want to embed a tile in your portal.

3.	Point to the tile, select **More options**, and then select **Open in focus mode**.

    > [!div class="mx-imgBorder"]
    > ![Open Power BI dashboard tile in focus mode](media/powerbi-dashboard-tile-focus.png "Open Power BI dashboard tile in focus mode")

4.	Copy the tile ID from the URL in the address bar. The tile ID is the value after /tiles/.

    > [!div class="mx-imgBorder"]
    > ![Power BI dashboard tile ID](media/powerbi-dashboard-tile-id.png "Power BI dashboard tile ID")
