angular
.module('app')
.directive('serverValidate', serverValidate)

function serverValidate() {

    return {

        require: 'ngModel',

        link: function (scope, ele, attrs, c) {

            //console.log('wiring up ' + attrs.ngModel + ' to controller ' + c.$name);

            scope.$watch('modelState', function () {
                if (scope.modelState == null) return;

                var modelStateKey = attrs.serverValidate || attrs.ngModel;
                modelStateKey = modelStateKey.replace('$index', scope.$index);
                //console.log('validation for ' + modelStateKey, attrs.serverValidate);

                if (scope.modelState[modelStateKey]) {
                    c.$setValidity('server', false);
                    c.$error.server = scope.modelState[modelStateKey];
                } else {
                    c.$setValidity('server', true);
                }

            });

            scope.$watch(attrs.ngModel, function (oldValue, newValue) {
                if (oldValue != newValue) {
                    c.$setValidity('server', true);
                    c.$error.server = [];
                }
            });

        }
    };

}
