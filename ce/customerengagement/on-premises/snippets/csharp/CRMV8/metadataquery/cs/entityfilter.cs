// <snippetentityfilter>



     // An array SchemaName values for non-intersect, user-owned entities that should not be returned.
     String[] excludedEntities = {
"WorkflowLog",
"Template",
"CustomerOpportunityRole",
"Import",
"UserQueryVisualization",
"UserEntityInstanceData",
"ImportLog",
"RecurrenceRule",
"QuoteClose",
"UserForm",
"SharePointDocumentLocation",
"Queue",
"DuplicateRule",
"OpportunityClose",
"Workflow",
"RecurringAppointmentMaster",
"CustomerRelationship",
"Annotation",
"SharePointSite",
"ImportData",
"ImportFile",
"OrderClose",
"Contract",
"BulkOperation",
"CampaignResponse",
"Connection",
"Report",
"CampaignActivity",
"UserEntityUISettings",
"IncidentResolution",
"GoalRollupQuery",
"MailMergeTemplate",
"Campaign",
"PostFollow",
"ImportMap",
"Goal",
"AsyncOperation",
"ProcessSession",
"UserQuery",
"ActivityPointer",
"List",
"ServiceAppointment"};

     //A filter expression to limit entities returned to non-intersect, user-owned entities not found in the list of excluded entities.
     MetadataFilterExpression EntityFilter = new MetadataFilterExpression(LogicalOperator.And);
     EntityFilter.Conditions.Add(new MetadataConditionExpression("IsIntersect", MetadataConditionOperator.Equals, false));
     EntityFilter.Conditions.Add(new MetadataConditionExpression("OwnershipType", MetadataConditionOperator.Equals, OwnershipTypes.UserOwned));
     EntityFilter.Conditions.Add(new MetadataConditionExpression("SchemaName", MetadataConditionOperator.NotIn, excludedEntities));
     MetadataConditionExpression isVisibileInMobileTrue = new MetadataConditionExpression("IsVisibleInMobile", MetadataConditionOperator.Equals, true);
     EntityFilter.Conditions.Add(isVisibileInMobileTrue);

// </snippetentityfilter>