---
title: How to add new custom forms for Opportunity, Quote, Order or Invoice entity (Project Service 2.x)
description: This topic describes how to add custom forms for Opportunity, Quote, Order or Invoice entity in Project Service 2.x
author: makk
manager: rchawla
ms.custom:
  - dyn365-projectservice
ms.date: 12/14/2018
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

# How to add new custom forms for Opportunity, Quote, Order or Invoice entity (Project Service 2.x)

## Type field (msdyn_ordertype)

Project Service solution relies on 'Type' (**msdyn_ordertype**) field of the Opportunity, Quote, Order and Invoice entities to distinguish between **Work-based** (which are handled by Project Service) and other versions of these entities (**Item-based**, **Service-based**). There is a lot of business logic on the client and server sides of the solution that depends on that field. It is important that the field is initialized with correct value when entity is created. Having this field initialized with the wrong value may result in wrong behaviors and some of business logic not being executed correctly (some thing may not work as expected).

## Automatic form switching

> NOTE: Automatic form switching has been deprecated in Project Service 3.x 

In order to avoid potential data corruption and wrong behaviors due to incorrect initialization and edits of the sales entity records the Project Service solution has added automatic form switching logic to the out of the box forms in order to bring user to the proper form for working with **Work-based** or any other type of Opportunity, Quote, Order and Invoice entities. When user opens **Work-based** version of Opportunity, Quote, Order or Invoice the form will be switched to 'Project Information' if the entity record is opened in the form not ment for working with **Work-based** versions of those entities. The automatic form switching logic relies on the mapping between **formId** and **msdyn_ordertype** that the form is ment to handle. All the out of the box forms have been added to that mapping, new custom forms have to be added manually in order to indicate which version of the entity (basing on the **msdyn_ordertype** of the entity) they are ment to handle. If the mapping is missing the form switching logic will switch to the default registered out of the box form basing on what value is saved in the **msdyn_ordertype** field of the entity.

## How to add custom form for Opportunity, Quote, Order or Invoice entity and enable it for the form switching logic.

> NOTE: This procedure is no longer needed for Project Service 3.x

The example below shows how to add custom 'My Project Information' form for working with **Work-based** Opportunities. The process for adding custom forms to Quote, Order and Invoice is similar.

* Create a custom version of 'Project Information' form.
  - Open 'Project Informaiton' form of the Opportunity entity and save it as 'My Project Information' form.
  - In the form properties of 'My Project Information' form make sure that form contains form initialization scripts from 'Project Information' form. Do not remove those as this may cause certain data to be incorrectly initialized.
  - Make sure that *'Type'* (**msdyn_ordertype**) field remains on the form, do not remove it, otherwise it will make initialization scripts fail.

* Obtain *formId* of the newly created from. This can be done in one of the following ways:
  - Export 'My Project Information' form as part of unmanaged solution and lookup *formId* in the customization.xml of the exported solution.
  - Open 'My Project Information' in the form editor window and search for GUID next to *fromId* parameter in the URL (see highlighted GUID):
> [!div class="mx-imgBorder"] 
> ![Screenshot about identifying formId of the new form](media/how-to-add-custom-forms-in-v2.0.png)

* Create proper **msdyn_ordertype** mapping for the *formId*.
  1. Edit the following Web Resource: ***msdyn_/SalesDocument/PSSalesDocumentCustomFormIds.js***
  2. Remove the code in the web resource and replace it with the following code:   
 
 
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
  
  3. Save and publish customizations.