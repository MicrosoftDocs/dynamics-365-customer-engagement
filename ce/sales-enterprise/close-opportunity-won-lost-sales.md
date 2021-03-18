---
title: "Close opportunities as won or lost (Dynamics 365 Sales) | MicrosoftDocs"
description: "Close the opportunity to indicate whether it was won or lost."
ms.date: 02/10/2021
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
---

# Close opportunities as won or lost (Sales Hub)

If your customer has accepted your proposal, congratulations! However, whether your customer accepted or declined your proposal, it's now time to close that opportunity.  
  
1. If you're using the Sales Hub app, in the site map, select **Opportunities**. 
    
2. Open the opportunity you want to edit.  
  
3. At the top of the **Opportunity** form, do one of the following:  

   - To close your opportunity as won, select **Close as Won**.  
 
   - To close your opportunity as lost, select **Close as Lost**.

      > [!div class="mx-imgBorder"]  
      > ![Close as Won and Close as Lost options on the Opportunity form](media/close-opportunity.png "Close as Won and Close as Lost options on the Opportunity form")

4. When you close the opportunity as **Won**, in the **Close Opportunity** dialog box, do the following, and select **OK**:

    - In **Actual Revenue**, Verify the amount, and make changes, if necessary.
    
    - In **Description**, enter details about what contributed to winning this opportunity. 

      > [!div class="mx-imgBorder"]  
      > ![Close Opportunity dialog box when the opportunity is won](media/close-as-won.png "Close Opportunity dialog box when the opportunity is won")

    When you close the opportunity as **Lost**, in the **Close Opportunity** dialog box, do the following, and select **OK**:
  
    -  In **Competitor**, select a competitor you lost this opportunity to.
    
    -  In **Description**, add more details around why the opportunity was lost.

        > [!div class="mx-imgBorder"]  
        > ![Close Opportunity dialog box when the opportunity is lost](media/close-as-lost.png "Close Opportunity dialog box when the opportunity is lost")

    > [!IMPORTANT]
    > If your system administrator has enabled custom fields on the Opportunity Close form, you may be required to fill in data in other fields as defined by your organization. 

When you close an opportunity record, all the information that you enter is available in the associated Opportunity Close record. To see the associated Opportunity Close records, on the **Related** tab, select **Activities**. Then, on the **Activities** tab, open the **Closed Activity Associated View**. 

For information on how to resolve the common errors that you may see while closing an opportunity, see the [troubleshooting guide](troubleshooting.md).

## Reopen a closed opportunity

If you've closed an opportunity as lost, but would like to start discussions about a potential sale, you may want to reopen a closed opportunity.

1. If you're using the Sales Hub app, in the site map, select **Opportunities**. 
   
2. To see all the closed opportunities, in the view selector, select the **Closed Opportunities** view.  

    > [!div class="mx-imgBorder"]  
    > ![Closed Opportunities view in the view selector](media/select-closed-opportunities-view.png "Closed Opportunities view in the view selector")

3. Select the opportunity that you want to reopen, and on the command bar, select **Reopen Opportunity**. The reopened opportunities start appearing in the open opportunities list.
  
### See also  
 [Nurture sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md)   
 [Print leads, quotes, and other records](../basics/print-leads-quotes-other-records.md)  
 [Dynamics 365 Sales troubleshooting guide](troubleshooting.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]