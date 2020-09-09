// <snippetgetsolutiondependencies6>


 Publisher publisher = new Publisher
 {
     UniqueName = "examplepublisher",
     FriendlyName = "An Example Publisher",
     Description = "This is an example publisher",
     CustomizationPrefix = _prefix
 };
 _publisherId = _serviceProxy.Create(publisher);

// </snippetgetsolutiondependencies6>