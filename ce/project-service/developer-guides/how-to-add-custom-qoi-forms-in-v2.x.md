---
title: Add new custom entity forms (Project Service 2.x)
description: This topic provides information about how to add custom entity forms for Opportunities, Quotes, Orders, or Invoices in Project Service 2.x.
author: makk
manager: kfend
ms.custom:
  - dyn365-projectservice
ms.date: 2/05/2019
ms.topic: article
ms.prod: Project Service
ms.service: business-applications
ms.author: makk
audience: admin
search.audienceType: 
  - admin
  - customizer
search.app: 
    - D365PS
---

# Add new custom entity forms (Project Service 2.x)

## Type field 

Microsoft Dynamics 365 for Project Service Automation (PSA) relies on the **Type** (**msdyn_ordertype**) field of the Opportunity, Quote, Order, and Invoice entities to distinguish between **Work-based** entities, which are handled by PSA, and other versions (**Item-based** adn **Service-based**) of these entities. There is a lot of business logic on the client and server sides of the solution that depends on the **Type** field and it is important that the field be initialized with correct value when the entity is created. If the field is initialized with the wrong value, it may result in incorrect behaviors and some business logic not being executed correctly.

## Automatic form switching

To avoid potential data corruption and unexpected behaviors due to the incorrect initialization and edit of the sales entity records, PSA has added automatic form switching logic to out-of-the-box forms. This will navigate users to the correct form for working with **Work-based** or any other type of Opportunity, Quote, Order, and Invoice entities. When the user opens the **Work-based** version of Opportunity, Quote, Order, or Invoice, the form will switch to **Project Information**. The automatic form switching logic relies on the mapping between **formId** and **msdyn_ordertype**. All out-of-the-box forms have been added to that mapping. Custom forms have to be manually added to indicate which version of the entity they are meant to handle. This is based on the **msdyn_ordertype**. If the form switching is missing from the mapping, logic will switch to the out-of-the-box form based on the value that is saved in the **msdyn_ordertype** field of the entity.

## Add custom forms and enable the form switching logic

The following example shows how to add the custom form, **My Project Information**, for working with **Work-based** opportunities. The same process is used to add custom forms to Quote, Order, and Invoice.

Complete the following steps to create a custom version of the **Project Information** form.

1. In the Opportunity entity, open the **Project Information** form and save a copy with the name, **My Project Information**.
2. Open the new form, and in the properties, make sure that the form initialization scripts from the **Project Information** form are there. 

  [!IMPORTANT]
  > Do not remove the scripts because doing so could cause certain data to be initialized incorrectly.

3. Verify that the field, **Type** (**msdyn_ordertype**) is on the form. 

  [!IMPORTANT]
  > Do not remove this field or the initialization scripts will fail.

4. Find the **formId** of the new form. You can do this in one of two ways:

  - Export the **My Project Information** form as part of an unmanaged solution and lookup **formId** in the customization.xml of the exported solution.
  - Open the **My Project Information** form in the form editor window and search for the GUID next to the **fromId** parameter in the URL as shown in the following graphic.

  > ![Screenshot about identifying formId of the new form](media/how-to-add-custom-forms-in-v2.0.png)

5. Create **msdyn_ordertype** mapping for the **formId** by editing the Web resource: ***msdyn_/SalesDocument/PSSalesDocumentCustomFormIds.js***. Remove the code in the resource and replace it with the following code:

            define(["require", "exports"], function (require, exports) {
            "use strict";
            var SalesDocumentCustomFormIds = (function () {
                function SalesDocumentCustomFormIds() {
                }
                SalesDocumentCustomFormIds.overwriteFormIds = function (mappedFormIds) {
                /*
                  ---- Notes ----
              
                  mappedFormIds[SalesEntity][OrderType] => The array of forms ids that support particular entity and order type
              
                  Add or overwrite customized formId for the particular entity and order type by calling:
              
                      mappedFormIds[<EntityType>][<msdyn_ordertype>].push("<formId>");
              
                  Allowed msdyn_ordertype values for reference:
                      ServiceBased: 690970002 (Field Service version of the entity)
                      WorkBased: 192350001 (Project Service version of the entity)
                      ItemBased: 192350000 (Regular out of the box entity)
              
                  Uncommend and update line below in order to register custom Project Service form for required entity:
                */		
                    //mappedFormIds[1][192350001].push("<formId>"); //Quote
                    //mappedFormIds[5][192350001].push("<formId>"); //Quote Line

                    //mappedFormIds[2][192350001].push("<formId>"); //Sales Order
                    //mappedFormIds[6][192350001].push("<formId>"); //Sales Order Line
                    
                    // In this example we have added new form for Opportunity
                    mappedFormIds[0][192350001].push("192EE537-DCC4-45D3-B7AF-EA694B9113D2"); //Opportunity
                    //mappedFormIds[4][192350001].push("<formId>"); //Opportunity Line
                };
                return SalesDocumentCustomFormIds;
            }());
            exports.default = SalesDocumentCustomFormIds;
            });
  
  6. Save and then publish the customizations.
