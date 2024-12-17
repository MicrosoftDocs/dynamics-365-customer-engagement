---
title: Close opportunities as won or lost
description: Close the opportunity to indicate whether it was won or lost. You can reopen it in future if the customer is interested in pursuing the opportunity.
ms.date: 12/3/2024
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: bap-template
content_well_notification:
  - AI-contribution
ai-usage: ai-assisted
---
# Close opportunities as won or lost 

Close the opportunity when you've won or lost the deal. Closing the opportunity helps you track the sales pipeline and forecast future sales.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|

## Close an opportunity  

1. In the Sales Hub sitemap, select **Opportunities**.  

2. Open the opportunity you want to close.  

1. Select the **Quotes** tab and ensure that all the quotes are in a **Closed** state. For instructions on how to close a quote, see [Close a quote](close-quote.md).
  
3. At the top of the **Opportunity** form, do one of the following:  

   - To close your opportunity as won, select **Close as Won**.  
 
   - To close your opportunity as lost, select **Close as Lost**.

        :::image type="content" source="media/close-opportunity.png" alt-text="Screenshot of the Opportunity form with the closure options.":::

4. Verify and update the details such as actual revenue, competitor, close date, and description.  

   > [!NOTE]
   > If your administrator has added custom fields to the Close Opportunity form, you'll see additional fields on the form. 

    :::image type="content" source="media/close-as-won.png" alt-text="Screenshot of the Close Opportunity form that appears when you select Close as Won"::: 

> [!NOTE]
> After you close an opportunity record, the forecast category of the opportunity is automatically updated to **Won** or **Lost** depending on your selection for the opportunity closure.


## View details entered while closing an opportunity

As a sales manager, you might want to view the details entered by your salespeople while closing an opportunity to understand the reason for winning or losing the opportunity.

1. In the Sales Hub sitemap, select **Opportunities** and select the **Closed Opportunities** view.
1. Open the opportunity you want to view the details for.
1. Select **Related** > **Activities**. 
1. In the view selector, select **Closed Activity Associated View**.
1. Double-click the **Opportunity Close** activity type to view the details entered while closing the opportunity.

    :::image type="content" source="media/view-closed-activity.png" alt-text="Screenshot of the Closed Activity Associated View."::: 


For information on how to resolve the common errors that you may see while closing an opportunity, see the [troubleshooting guide](/troubleshoot/dynamics-365/sales/troubleshoot-opportunities-issues).

## Reopen a closed opportunity

You can reopen a closed opportunity if the customer is interested in pursuing the opportunity. 

1. In the Sales Hub sitemap, select **Opportunities**.
   
2. To see all the closed opportunities, in the view selector, select the **Closed Opportunities** view.  

3. Select the opportunity that you want to reopen, and on the command bar, select **Reopen Opportunity**. 


[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information  
[Nurture sales from lead to order](nurture-sales-from-lead-order-sales.md)    
[Dynamics 365 Sales troubleshooting guide](troubleshooting.md)  
[Troubleshoot issues with opportunities](/troubleshoot/dynamics-365/sales/troubleshoot-opportunities-issues#opportunity-issues-and-resolution-for-salespeople)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
