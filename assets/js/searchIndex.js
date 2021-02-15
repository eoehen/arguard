
var camelCaseTokenizer = function (builder) {

  var pipelineFunction = function (token) {
    var previous = '';
    // split camelCaseString to on each word and combined words
    // e.g. camelCaseTokenizer -> ['camel', 'case', 'camelcase', 'tokenizer', 'camelcasetokenizer']
    var tokenStrings = token.toString().trim().split(/[\s\-]+|(?=[A-Z])/).reduce(function(acc, cur) {
      var current = cur.toLowerCase();
      if (acc.length === 0) {
        previous = current;
        return acc.concat(current);
      }
      previous = previous.concat(current);
      return acc.concat([current, previous]);
    }, []);

    // return token for each string
    // will copy any metadata on input token
    return tokenStrings.map(function(tokenString) {
      return token.clone(function(str) {
        return tokenString;
      })
    });
  }

  lunr.Pipeline.registerFunction(pipelineFunction, 'camelCaseTokenizer')

  builder.pipeline.before(lunr.stemmer, pipelineFunction)
}
var searchModule = function() {
    var documents = [];
    var idMap = [];
    function a(a,b) { 
        documents.push(a);
        idMap.push(b); 
    }

    a(
        {
            id:0,
            title:"ExceptionMessageResourceManager",
            content:"ExceptionMessageResourceManager",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard/ExceptionMessageResourceManager',
            title:"ExceptionMessageResourceManager",
            description:""
        }
    );
    a(
        {
            id:1,
            title:"ExceptionMessageResourceManagerTest",
            content:"ExceptionMessageResourceManagerTest",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard/ExceptionMessageResourceManagerTest',
            title:"ExceptionMessageResourceManagerTest",
            description:""
        }
    );
    a(
        {
            id:2,
            title:"ArgumentEmtpyGuardTest",
            content:"ArgumentEmtpyGuardTest",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard/ArgumentEmtpyGuardTest',
            title:"ArgumentEmtpyGuardTest",
            description:""
        }
    );
    a(
        {
            id:3,
            title:"ArgumentEmtpyGuard",
            content:"ArgumentEmtpyGuard",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard/ArgumentEmtpyGuard',
            title:"ArgumentEmtpyGuard",
            description:""
        }
    );
    a(
        {
            id:4,
            title:"ArgumentEnumerableGuardTest",
            content:"ArgumentEnumerableGuardTest",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard/ArgumentEnumerableGuardTest',
            title:"ArgumentEnumerableGuardTest",
            description:""
        }
    );
    a(
        {
            id:5,
            title:"ArgumentEnumerableGuard",
            content:"ArgumentEnumerableGuard",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard/ArgumentEnumerableGuard',
            title:"ArgumentEnumerableGuard",
            description:""
        }
    );
    a(
        {
            id:6,
            title:"ArgumentNullGuardTest",
            content:"ArgumentNullGuardTest",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard/ArgumentNullGuardTest',
            title:"ArgumentNullGuardTest",
            description:""
        }
    );
    a(
        {
            id:7,
            title:"ArgumentLessThanZeroGuardTest",
            content:"ArgumentLessThanZeroGuardTest",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard/ArgumentLessThanZeroGuardTest',
            title:"ArgumentLessThanZeroGuardTest",
            description:""
        }
    );
    a(
        {
            id:8,
            title:"ArgumentNullGuard",
            content:"ArgumentNullGuard",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard/ArgumentNullGuard',
            title:"ArgumentNullGuard",
            description:""
        }
    );
    a(
        {
            id:9,
            title:"ArgumentLessThanGuardTest",
            content:"ArgumentLessThanGuardTest",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard/ArgumentLessThanGuardTest',
            title:"ArgumentLessThanGuardTest",
            description:""
        }
    );
    a(
        {
            id:10,
            title:"ArgumentLessThanGuard",
            content:"ArgumentLessThanGuard",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard/ArgumentLessThanGuard',
            title:"ArgumentLessThanGuard",
            description:""
        }
    );
    a(
        {
            id:11,
            title:"ArgumentLessOrEqualThanZeroGuardTest",
            content:"ArgumentLessOrEqualThanZeroGuardTest",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard/ArgumentLessOrEqualThanZeroGuardTest',
            title:"ArgumentLessOrEqualThanZeroGuardTest",
            description:""
        }
    );
    a(
        {
            id:12,
            title:"ValidatedNotNullAttribute",
            content:"ValidatedNotNullAttribute",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard/ValidatedNotNullAttribute',
            title:"ValidatedNotNullAttribute",
            description:""
        }
    );
    var idx = lunr(function() {
        this.field('title');
        this.field('content');
        this.field('description');
        this.field('tags');
        this.ref('id');
        this.use(camelCaseTokenizer);

        this.pipeline.remove(lunr.stopWordFilter);
        this.pipeline.remove(lunr.stemmer);
        documents.forEach(function (doc) { this.add(doc) }, this)
    });

    return {
        search: function(q) {
            return idx.search(q).map(function(i) {
                return idMap[i.ref];
            });
        }
    };
}();
