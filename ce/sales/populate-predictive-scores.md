---
title: Populate predictive scores using custom scoring model
description: Learn how to use the msdyn_predictivescores entity to update predictive lead and opportunity scores in your application."
ms.date: 01/22/2025
ms.topic: overview
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/02/2023
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Populate predictive scores using custom scoring model

If you'd like to use your own scoring model to predict the likelihood of a lead or opportunity closing, use the `msdyn_predictivescores` entity to populate predictive scores for your leads and opportunities. 

## Add predictive score for a specific record

Use the POST request to add a predictive score for a specific record. 

### Sample request


```rest
POST /api/data/v9.0/msdyn_predictivescores HTTP/1.1
Content-Type: application/json
Host: contoso.crm.dynamics.com
Content-Length: 158
 
{
  "msdyn_score": 90,
  "msdyn_scoretrend": 0,
  "msdyn_grade": 0,
  "msdyn_entityid": "00aa00aa-bb11-cc22-dd33-44ee44ee44ee",
  "msdyn_entitytype": "lead"
}
```

### Parameters

`Host`: The URL of your Dynamics 365 Sales environment.  
`msdyn_score`: The predictive score value.  
`msdyn_scoretrend`: The trend of the score.  
`msdyn_grade`: The grade associated with the score.  
`msdyn_entityid`: The unique identifier of the entity.  
`msdyn_entitytype`: The type of entity - "lead" or "opportunity".  

### Response

**Status:** 204 No Content

## Update predictive score for a specific record

Use the PATCH request to update a predictive score for a specific record.

### Sample request


```rest
PATCH /api/data/v9.0/msdyn_predictivescores(msdyn_entityid=%2700aa00aa-bb11-cc22-dd33-44ee44ee44ee%27,msdyn_entitytype=%27lead%27) HTTP/1.1
Content-Type: application/json
Host: contoso.crm.dynamics.com
Content-Length: 68
 
{
  "msdyn_score": 95,
  "msdyn_scoretrend": 0,
  "msdyn_grade": 0
}
```

### Parameters

`Host`: The URL of your Dynamics 365 Sales environment.  
`msdyn_score`: The predictive score value.  
`msdyn_scoretrend`: The trend of the score.  
`msdyn_grade`: The grade associated with the score.  

### Response

**Status:** 204 No Content