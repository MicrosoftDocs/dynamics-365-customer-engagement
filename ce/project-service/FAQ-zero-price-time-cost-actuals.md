---

title: Why is the price defaulting to zero on time cost actuals? 
description: Troubleshooting why a price is defaulting to 0 on time cost actuals.
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 8/21/2018
ms.topic: article
ms.prod: Project Service
ms.service: business-applications
ms.technology: 
ms.author: rumant
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---

# Why is the price defaulting to zero on time cost actuals?

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

This FAQ applies to actuals where the transaction class is set to Time and transaction type is Cost. The following three checks will help you troubleshoot why the price is defaulting to 0 on time cost actuals.
 
## Check 1: Identify the cost price list for the project

Find the project from the project field of the actual and then go to the project page. Click on the contracting unit link in the field. On the Contracting Unit page, check if the contracting unit has a price list in the Cost Price Lists grid.

If there is more than one price list, you have isolated the problem. Project Service only supports one price list per organizational unit. Remove all prices lists from this entity until there is only one price list attached in the Cost Price Lists grid of the Organizational Unit.

If there are no price lists attached to the Organizational Unit, make a note of the currency of the Organizational unit. Go to the Project Service and then Parameters and open the Price Lists tab. Check if there are any price lists with context set to Cost and currency that matches the currency of the Organizational Unit.
 
If there are no price lists that match that criteria, you have isolated the problem. Make sure to have at least one price list whose context is set to Cost and whose currency matches the currency of the Organizational Unit.

If there is more than one price list that match that criteria, continue reading this document to make more checks.

## Check 2: Are any of the price lists identified above valid for the specific date of the time cost actual?

For Project Service to consider a price list for defaulting price, that price list should be applicable for the date on the time cost actual. Check the following to see if the price list(s) identified above are applicable:

- Check if the start and end dates on the general tab for the price lists attached aren’t empty. If the start and end dates on price lists identified above are empty, you have isolated the problem. 
- Make a note of the start date field on your time cost actual and check if any of the price lists identified is applicable for that date. For example, the date of the time cost actual should fall within the start date and end date on the price list. 
	- If there is no price list that covers that date on the time cost actual, you have isolated the problem. Modify the start and end dates of the price list to ensure that the price list covers the date of the time cost actual. 
	- If there is more than one price list that covers the date on the time cost actual, you have isolated the problem. You can fix this by editing the start and end dates of the price list(s) so that there is only one price list that covers the date of the time cost actual. 
	- If there is only one price list that covers that date of the time cost actual, move to the next check in the document.
Once you’ve done made the required fixes, recreate a time entry, approve it, and verify that the time cost actual shows a valid price.

## Check 3: Is there a price in the price list for the pricing dimensions on the time cost actual?

If you have successfully completed Check 1 and Check 2, you should now have only one price list that is applicable for the date of the time cost actual. Open this Price List and go to the Role Prices tab. Make sure that there is a row in the grid for the pricing dimensions on the time cost actual.

If there is no row in the role price grid for the pricing dimensions on the time cost actual, then you have isolated the problem. Create a row in the Role prices grid for the pricing dimensions on your time cost actual. Once this is done, recreate time entry, approve it, and verify that the time cost actual shows a valid price.
 
If you still don't see a valid price on your time cost actual after you’ve done the three checks above, please log a support ticket.



