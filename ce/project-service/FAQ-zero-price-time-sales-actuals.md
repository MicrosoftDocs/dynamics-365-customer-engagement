---

title: Why is the price defaulting to zero on time sales actuals? 
description: Troubleshooting why a price is defaulting to 0 on time sales actuals.
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
# Why is price defaulting to zero on time sales actuals?

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

This FAQ applies to actuals where the transaction class is set to Time and transaction type is Unbilled Sales. The following three checks will help you troubleshoot why price (bill rate) is defaulting to 0 on time sales actuals.

## Check 1: Identify the sales price list for the project

Find the project from the project field of the actual and go to the project page. Then go to the Sales tab and on Project Contract lines grid, click on the link in the Project Contract field. The project Contract page will open. On the Project Contract page, go to the Project Price Lists tab. Check if there is at least one price list attached here. 
If there is no price list attached in the Project Price Lists grid of the Project Contract you have isolated the problem. Attach a price list to the Project Price lists grid. The price lists allowed to be attached here should have the context field set to Sales and the currency field on the price list should match the currency field on the Project Contract. Once you’ve done made the required fixes, recreate a time entry, approve it, and verify that the unbilled sales actual shows a valid price. 

If you have one or more price lists attached in the Project Price Lists grid of the Project Contract, proceed to the next check in the document.

## Check 2: Are any of the price lists identified above valid for the specific date of the time sales actual?

For Project Service to consider a price list for defaulting price, that price list should be applicable for the date on the time sales actual. Check the following to see if the price list(s) identified above are applicable:
- Check if the start and end dates on the general tab for the price lists attached aren’t empty. If the start and end dates on price lists identified above are empty, you have isolated the problem. 
- Make a note of the start date field on your time sales actual and check if any of the price lists identified is applicable for that date. For example, the date of the time sales actual should fall within the start date and end date on the price list. 
	- If there is no price list that covers that date on the time sales actual, you have isolated the problem. Modify the start and end dates of the price list to ensure that the price list covers the date of the time sales actual. 
	- If there is more than one price list that covers the date on the time sales actual, you have isolated the problem. You can fix this by editing the start and end dates of the price list(s) so that there is only one price list that covers the date of the time sales actual. 
	- If there is only one price list that covers that date of the time sales actual, go to Check 3.
Once you’ve done made the required fixes, recreate a time entry, approve it, and verify that the time sales actual shows a valid price.

## Check 3: Is there a price in the price list for the pricing dimensions on the time sales actual?

If you have successfully completed Check 1 and Check 2, you should now have only one price list that is applicable for the date of the time sales actual. Open this Price List and navigate to the Role Prices tab. Make sure that there is a row in the grid for the pricing dimensions on the Time sales actual.

If there is no row in the role price grid for the pricing dimensions on the time sales actual, then you have isolated the problem. Create a row in the Role prices grid for the pricing dimensions on your time sales actual. Once this is done, recreate time entry, approve it, and verify that the time sales actual shows a valid price.

If you still don't see a valid price on your time sales actual after following the three checks above, please log a support ticket. 

