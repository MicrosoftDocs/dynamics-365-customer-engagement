---
title: "Route records using unified routing | MicrosoftDocs"
description: "Learn how to manually route records using basic routing for records."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 06/04/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---
# Route records in Customer Service using unified routing

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

After you set up and enable a record for routing, you can manually start the routing for the records using the **Save & Route** button on the record forms.

## Manually route records

When you enable a record for routing, you'll see the **Save & Route** option on the form ribbon on the command bar and **Apply Routing rules** on the record view ribbon on the command bar. You can use these commands to route the record.

1. Sign in to your model-driven app.

2. Select a routed record. <br> For example, in this procedure, **Leads** is enabled for routing, so you can see the **Save & Route** button on the Leads form command bar.

3. Select **Leads** in the site map, and you can view the **Apply Routing rules**  in the entity view ribbon command bar. Selecting **Apply Routing rules** also routes the record.

4. Select a lead record from the **My Open Leads** view.

5. Select **Save & Route** on the command bar. The **Route Case** dialog box appears.

6. Select **Route**. The record is routed based on the active routing rule set.

    > [!div class=mx-imgBorder] 
    > ![Manual trigger](media/manual-trigger.png "Manual trigger")


### See also

[Overview of routing](overview-unified-routing.md)  
[Set up routing for records](set-up-record-routing.md)  
[Automatically route records using Flow](routing-trigger-automatic.md#automatically-route-records-using-flow)  
[Sample code to trigger routing for non-case records](trigger-routing-non-case-records.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
