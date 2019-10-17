---

title: Why is the price defaulting to zero on expense sales actuals?
description: The following three checks will help you troubleshoot why price is defaulting to 0 on expense sales actuals.
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 8/21/2018
ms.topic: article
ms.prod: Applies to all versions of Project Service
ms.service: business-applications
ms.technology: Applies to all versions of Project Service
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

# Why is the price defaulting to zero on expense sales actuals?

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

This FAQ applies to expense actuals where the transaction class is set to Expense and transaction type is Unbilled Sales. The following three checks will help you troubleshoot why price (bill rate) is defaulting to 0 on expense sales actuals.

## Check 1: Identify the sales price list for project

Find the project from the project field of the actual and go to the project page. Then go to the Sales tab. On the Project Contract lines grid, click on the link in the Project Contract field. The Project Contract page will open. On the Project Contract page, go to the Project Price Lists tab. Check if there is at least one price list attached here.

If there is no price list attached in the Project Price Lists grid of the Project Contract do the following:

- Attach a price list to the Project Price lists grid. The price lists allowed to be attached here should have the context field set to Sales and the currency field on the price list should match the currency field on the Project Contract. Once you’ve made the required fixes, recreate an expense entry, approve it, and verify that the unbilled sales actual shows a valid price.
- If you have one or more price lists attached in the Project Price Lists grid of the Project Contract, go to Check 2.

## Check 2: Are any of the price lists identified above valid for the specific date of the expense actual?

For Project Service to consider a price list for defaulting price, that price list should be applicable for the date on the expense sales actual. Check the following to see if the price list(s) identified above are applicable:

- Start by checking if start and end dates on the general tab for the price lists attached aren’t empty. If the start and end dates on the price lists identified above are empty, you have isolated the problem. 
- Make a note of the start date field on your expense sales actual and check if any of the price lists identified is applicable for that date. For example, the date of the expense actual should fall within the start date and end date on the price list. 
	- If there is no price list that covers that date on the expense sales actual, you have isolated the problem. Modify the start and end dates of the price list to ensure that the price list covers the date of the expense actual. 
	- If there is more than one price list that covers the date on the expense sales actual, you have isolated the problem. You can fix this by editing the start and end dates of the price list(s) so that there is only one price list that covers the date of the expense actual. 
	- If there is only one price list that covers that date of the expense actual, move to Check 3.
Once you’ve done made the required fixes, recreate an expense entry, approve it, and verify that the unbilled sales actual shows a valid price.

## Check 3: Is there a valid price for the expense category in the applicable project price list? 

If you have successfully completed Check 1 and Check 2, you should now have only one project price list that is applicable for the date of the expense sales actual. Open this Project Price List and go to the Category Prices tab. Make sure that there is a row in the grid for the specific expense category on the Expense actual.
 
- If there is no row, then you have isolated the problem. Create a row in the Category price grid for the category on your expense actual. Once this is done, recreate an expense entry, approve it, and verify that the unbilled sales actual shows a valid price. 
- If there is a row for the expense category in the category prices grid, check if it has a valid price.

To understand what a valid price is, use these methods:

- If the Pricing Method field on the Category price line is set to At Cost, then the unit rate on your Expense sales actual will be defaulted to the value in the Expense entry.
- If the Pricing Method field on the Category price line is set to Markup Percentage, then check if the Percent field is set to a valid value. The unit rate on your Expense sales actual is defaulted by applying this markup percent to the price in the Expense entry.
- If the Pricing Method field on the Category price line is set to Price per Unit, then check if the Price field is set to a valid value. The unit rate on your Expense sales actual will be defaulted to the currency amount specified in the Price field.

If the price setup for the expense category isn't valid, then you have isolated the problem. The solution is to edit the category price line with a valid price for the expense category in accordance with the rules above. Once you’ve done that, recreate an expense entry, approve it, and then check that the unbilled sales actual gets a valid price.

If you still don't see a valid price on your expense sales actual after doing the three checks above, please log a support ticket.


