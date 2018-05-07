---
title: "Configure a redirect step type for a portal in Dynamics 365 | MicrosoftDocs"
description: "Instructions to add and configure a redirect step for a portal."
ms.custom: dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 12d451bf-cdcc-4d7c-b617-4c5a0d624d00
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Add a redirect step type

The Redirect Step Type allow for a redirect of the User's browser session to another page in the portal or to an external URL. This is useful for seamlessly directing flow.

| Name                                                            | Description                                                                                                                                                                                  |
|-----------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| External URL                                                    | Requires On Success set to Redirect. Specify a URL to an external resource on the web.                                                                                                       |
| or Web Page                                                     | Requires On Success set to Redirect. Select a Web Page from the current website.                                                                                                             |
| Append Existing Query String                                    | Requires On Success set to Redirect. When checked the existing query string parameters will be added to the target URL prior to redirection.                                                 |
| Append Record ID To Query String                                | Requires On Success set to Redirect. When checked the ID of the record created is appended to the query string of the URL being redirected to.                                               |
| Record ID Query String Parameter Name                           | Requires On Success set to Redirect. The name of the ID parameter in the query string of the URL being redirected to.                                                                        |
| Append Custom Query String                                      | Requires On Success set to Redirect. A custom string that can be appended to the existing Query String of the redirect URL.                                                                  |
| Append Attribute Value to Query String - Parameter Name         | Requires On Success set to Redirect. A name to give to the parameter that correlates to the attribute value on the target entity that gets appended to the Query String of the redirect URL. |
| Append Attribute Value to Query String - Attribute Logical Name | Requires On Success set to Redirect. A logical name of an attribute on the target entity to get the value to be appended to the Query String of the redirect URL.                            |

### See also

[Configure a Dynamics 365 portal](configure-portal.md)  
[Define entity forms and custom logic within the Dynamics 365 portal](entity-forms-custom-logic.md)  
[Web Form steps for portals](web-form-steps.md)  
[Load Form/Load Tab step type](load-form-step.md)  
[Conditional step type](add-conditional-step.md)  
[Add custom JavaScript](add-custom-javascript.md)  

