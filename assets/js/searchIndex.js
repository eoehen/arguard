
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
            title:"ArgumentLongBetweenGuard",
            content:"ArgumentLongBetweenGuard",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard.Between/ArgumentLongBetweenGuard',
            title:"ArgumentLongBetweenGuard",
            description:""
        }
    );
    a(
        {
            id:1,
            title:"ArgumentIntLessThanGuard",
            content:"ArgumentIntLessThanGuard",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard.LessThan/ArgumentIntLessThanGuard',
            title:"ArgumentIntLessThanGuard",
            description:""
        }
    );
    a(
        {
            id:2,
            title:"ArgumentLongLessThanGuard",
            content:"ArgumentLongLessThanGuard",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard.LessThan/ArgumentLongLessThanGuard',
            title:"ArgumentLongLessThanGuard",
            description:""
        }
    );
    a(
        {
            id:3,
            title:"ArgumentDirectoryPathGuard",
            content:"ArgumentDirectoryPathGuard",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard.Filesystem/ArgumentDirectoryPathGuard',
            title:"ArgumentDirectoryPathGuard",
            description:""
        }
    );
    a(
        {
            id:4,
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
            id:5,
            title:"ArgumentEqualGuard",
            content:"ArgumentEqualGuard",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard/ArgumentEqualGuard',
            title:"ArgumentEqualGuard",
            description:""
        }
    );
    a(
        {
            id:6,
            title:"ArgumentFilePathGuard",
            content:"ArgumentFilePathGuard",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard.Filesystem/ArgumentFilePathGuard',
            title:"ArgumentFilePathGuard",
            description:""
        }
    );
    a(
        {
            id:7,
            title:"ArgumentDateTimeTodayGuard",
            content:"ArgumentDateTimeTodayGuard",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard/ArgumentDateTimeTodayGuard',
            title:"ArgumentDateTimeTodayGuard",
            description:""
        }
    );
    a(
        {
            id:8,
            title:"ArgumentTypeGuard",
            content:"ArgumentTypeGuard",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard/ArgumentTypeGuard',
            title:"ArgumentTypeGuard",
            description:""
        }
    );
    a(
        {
            id:9,
            title:"ArgumentDecimalLessThanGuard",
            content:"ArgumentDecimalLessThanGuard",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard.LessThan/ArgumentDecimalLessThanGuard',
            title:"ArgumentDecimalLessThanGuard",
            description:""
        }
    );
    a(
        {
            id:10,
            title:"ArgumentDecimalBetweenGuard",
            content:"ArgumentDecimalBetweenGuard",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard.Between/ArgumentDecimalBetweenGuard',
            title:"ArgumentDecimalBetweenGuard",
            description:""
        }
    );
    a(
        {
            id:11,
            title:"ArgumentBooleanGuard",
            content:"ArgumentBooleanGuard",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard/ArgumentBooleanGuard',
            title:"ArgumentBooleanGuard",
            description:""
        }
    );
    a(
        {
            id:12,
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
            id:13,
            title:"ArgumentIntBetweenGuard",
            content:"ArgumentIntBetweenGuard",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard.Between/ArgumentIntBetweenGuard',
            title:"ArgumentIntBetweenGuard",
            description:""
        }
    );
    a(
        {
            id:14,
            title:"ArgumentDateTimeNowGuard",
            content:"ArgumentDateTimeNowGuard",
            description:'',
            tags:''
        },
        {
            url:'/arguard/api/oehen.arguard/ArgumentDateTimeNowGuard',
            title:"ArgumentDateTimeNowGuard",
            description:""
        }
    );
    a(
        {
            id:15,
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
