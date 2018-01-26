---
title: "Sample: Generic virtual entity data provider plug-in (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrates how to implement a generic custom Dynamics 365 virtual entity plug-in."
ms.custom: ""
ms.date: 01/19/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d329dade-16c5-46e9-8dec-4b8efb996d24
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---

# Sample: Generic virtual entity data provider plug-in


> [!NOTE]
> ![This page is under construction. Check back soon!](../../media/under_construction.png "Coming soon") [!INCLUDE[cc-under-construction](../../includes/cc-under-construction.md)]

<!-- 
[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. 

  
## Demonstrates  
This sample shows a minimal implementation for a generic [!INCLUDE[pn-dynamics365](../../includes/pn-dynamics-365.md)] virtual entity data provider plug-in, **DropboxRetrieveMultiplePlugin**, for the [Dropbox](https://www.dropbox.com/) file-sharing service. It uses the "bare metal" approach, translating the [QueryExpression](https://msdn.microsoft.com/library/microsoft.xrm.sdk.query.queryexpression.aspx) through the creation of the custom visitor class, **DropBoxExpressionVisitor**. It returns a collection of the files that satisfy the search criteria as an [EntityCollection](https://msdn.microsoft.com/library/microsoft.xrm.sdk.entitycollection.aspx). 


 QUESTION: Does this satisfy both the Retrieve and RetrieveMultiple messages? 
  
## Example  

```csharp  

public class DropBoxExpressionVisitor : QueryExpressionVisitorBase
{
    public string SearchKeyWords { get; private set; }

    public override void Visit(FilterExpression filter)
    {
        // Very simple visitor that extracts search keywords
        if (filter.Conditions.Count > 0)
        {
            foreach (ConditionExpression condition in filter.Conditions)
            {
                if (condition.Operator == ConditionOperator.Like && condition.Values.Count > 0)
                {
                    string exprVal = (string)condition.Values[0];

                    if (exprVal.Length > 2)
                    {
                        this.SearchKeyWords += " " + exprVal.Substring(1, exprVal.Length - 2);
                    }
                }
            }
        }
    }
}

public class DropboxRetrieveMultiplePlugin : IPlugin
{
    public void Execute(IServiceProvider serviceProvider)
    {
        var context = serviceProvider.Get<IPluginExecutionContext>();
        var qe = context.InputParameterOrDefault<QueryExpression>("Query");
        if (qe != null)
        {
            var visitor = new DropBoxExpressionVisitor();
            qe.Accept(visitor);
            using (var dbx = new DropboxClient(AccessToken))
            {
                if (visitor.SearchKeyWords != string.Empty)
                {
                    var searchCriteria = new SearchArg(string.Empty, visitor.SearchKeyWords);
                    var task = Task.Run(() => this.SearchFile(dbx, searchCriteria));
                    context.OutputParameters["BusinessEntityCollection"] = task.Result;
                }
            }
        }
    }

    public async Task<EntityCollection> SearchFile(DropboxClient dbx, SearchArg arg)
    {
        EntityCollection ec = new EntityCollection();
        var list = await dbx.Files.SearchAsync(arg);
        foreach (var item in list.Matches)
        {
            if (item.Metadata.IsFile)
            {
                Entity e = new Entity("new_dropbox");
                e.Attributes.Add("new_dropboxid", Guid.NewGuid());
                e.Attributes.Add("new_filename", item.Metadata.AsFile.Name);
                e.Attributes.Add("new_filesize", item.Metadata.AsFile.Size);
                e.Attributes.Add("new_modifiedon", item.Metadata.AsFile.ServerModified);
                ec.Entities.Add(e);
            }
        }
        return ec;
    }
}

``` 
-->
  
### See also

[Get started with virtual entities](get-started-ve.md)<br />
[Custom virtual entity data providers](custom-ve-data-providers.md)
