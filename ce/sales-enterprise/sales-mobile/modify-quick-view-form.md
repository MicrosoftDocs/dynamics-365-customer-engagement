---
title: Modify quick view forms for the Dynamics 365 Sales mobile app
description: Learn to modify quick view forms for the Dynamics 365 Sales mobile app.
ms.date: 02/18/2021
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Modify quick view forms

Dynamics 365 Sales mobile app uses the quick view form to display details of a table. It is a lightweight form and doesn't include all attributes of the table. For more information about quick view forms, see [Create a quick view form](https://docs.microsoft.com/powerapps/maker/model-driven-apps/create-edit-quick-view-forms).

If you have created multiple quick view forms, the mobile app uses the first form in the quick view form order. For example, if you have the following quick view forms for the Contact table, you'll see the form order as shown in the following table.

|Form order|Form name|
|----------|---------|
|1|Contact quick view form one|
|2|Contact quick view form two|
|3|Contact quick view form three|
|||

The mobile app displays information as per the fields defined in the Contact quick view form one.

If you want to change the fields to be displayed in the mobile app, modify the first quick view form in the form order. If you want a different quick view form to be used for displaying information, move the form to the top of the form order. More information on setting form order: [Set the form order](https://docs.microsoft.com/powerapps/maker/model-driven-apps/control-access-forms#set-the-form-order)

### See also

[Use the Dynamics 365 Sales mobile app](use-sales-mobile-app.md)    
[Learn the basics](learn-basics-mobile-app.md)