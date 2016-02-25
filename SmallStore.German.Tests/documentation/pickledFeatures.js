jsonPWrapper ({
  "Features": [
    {
      "RelativeFolder": "KorrektesRunden.feature",
      "Feature": {
        "Name": "Korrektes Runden",
        "Description": "Damit jeder erhält was er verdient, muss korrekt auf \r\nden nächsten 0.5er Schritt gerundet werden.",
        "FeatureElements": [
          {
            "Examples": [
              {
                "Name": "",
                "Description": "",
                "TableArgument": {
                  "HeaderRow": [
                    "Credits",
                    "GerundeteCredits"
                  ],
                  "DataRows": [
                    [
                      "1.1",
                      "1"
                    ],
                    [
                      "1.2",
                      "1"
                    ],
                    [
                      "1.24",
                      "1"
                    ],
                    [
                      "1.25",
                      "1.5"
                    ],
                    [
                      "1.26",
                      "1.5"
                    ],
                    [
                      "1.5",
                      "1.5"
                    ],
                    [
                      "1.51",
                      "1.5"
                    ],
                    [
                      "1.6",
                      "1.5"
                    ],
                    [
                      "1.74",
                      "1.5"
                    ],
                    [
                      "1.75",
                      "2"
                    ],
                    [
                      "2.0",
                      "2"
                    ]
                  ]
                }
              }
            ],
            "Name": "Werte werden korrekt gerundet",
            "Description": "",
            "Steps": [
              {
                "Keyword": "When",
                "NativeKeyword": "Wenn ",
                "Name": "der Eintrag <Credits> hat"
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Dann ",
                "Name": "wird <GerundeteCredits> angezeigt"
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          }
        ],
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false
      }
    }
  ],
  "Configuration": {
    "GeneratedOn": "19 Januar 2016 22:45:31"
  }
});