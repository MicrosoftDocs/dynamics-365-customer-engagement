---
title: "Dynamics 365 Portal FAQ | MicrosoftDocs"
description: "Frequently asked questions in Dynamics 365 Portal."
ms.custom: 
  - dyn365-portal
ms.date: 08/06/2018
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: E68386D7-2015-4F23-A1D4-A69517B37E0D
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: shubhadaj
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Portals
---

# Dynamics 365 Portal FAQ

We have compiled a list of frequently asked questions and provided brief answers to help you get to your information quickly.

## How to change the audience and type of a portal after it is provisioned?

After you have provisioned a portal, the option to change the portal audience is disabled.

However, you can change the audience and type of a portal after it is provisioned by following the steps mentioned in the  [Change the Dynamics 365 instance, audience, or type of portal](change-dynamics-instance.md) article.

## How to change the base URL of a portal after it is provisioned?

You can change the base URL of a portal after it is provisioned by following the steps mentioned in the [Change the base URL of a portal](change-base-url.md) article.

## How to redirect a user to a default page after signing-in?

You can configure a portal to redirect a user to a default page after signing in. To achieve this functionality, you can include a JavaScript code in the Home web template.

For example, if you want to redirect all users to the Forums page after signing in, you can include a JavaScript code in the Home web template as follows:

```xml
{% if user %}
//if any user logs in
<script>
  window.location.href='./forums/'
</script>
{% else %}
//Home web page code, if you don't want to display the page when the user is being redirected
{% endif %}
//Home web page code, if you want to display the page when the user is being redirected
```

For more information on working with Liquid templates, see [Work with Liquid templates](custom-templates-dynamic-content.md).
