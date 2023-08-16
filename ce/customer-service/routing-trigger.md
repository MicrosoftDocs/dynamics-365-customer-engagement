---
title: "Route records manually using unified routing | MicrosoftDocs"
description: "Learn how to route records manually using the Save & Route option on the form command bar and Apply Routing Rule on the home page grid."
ms.date: 07/24/2023
ms.service: dynamics-365-customerservice
ms.topic: article
author: "neeranelli"
ms.author: nenellim
---
# Route records manually using unified routing

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]


## Route records using Save & Route or Apply Routing Rule options

After you set up and enable a record for routing, you can start routing a record manually, either by:
- Selecting a record on the home page grid and then selecting **Apply Routing Rule** on the toolbar.
- Opening a record form and then selecting  **Save & Route** on the form command bar.

> [!NOTE]
> The **Apply Routing Rule** button doesn't display on the home page grid of Activities.

To manually route records:

1. Sign in to your model-driven app.

2. Select the record you want to route on the home page grid and then select **Apply Routing Rule**.
   Alternatively, open the record form and select **Save & Route** on the form command bar.

   The **Route Case** dialog box appears.

3. Select **Route**. The record is routed based on the record routing configuration.

If unified routing is enabled, on the **Customer Service Agent Dashboard** page, you must use the system view **Cases Available to Work On** to pick cases to work on.

### See also

[Overview of routing](overview-unified-routing.md)  
[Set up routing for records](set-up-record-routing.md)  
[Automatically route records using custom flow](routing-trigger-automatic.md)  
[Sample code to trigger routing for non-case records](trigger-routing-non-case-records.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
