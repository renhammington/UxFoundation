var ux = {

    dropdowns: {
        init: function () {
            $(".selectpicker").selectpicker();
        }
    },

    validation: {
        init: function () {
            $('span.field-validation-valid, span.field-validation-error').each(function () {
                $(this).addClass('help-inline');
            });

            $('form').submit(function () {
                if ($(this).valid()) {
                    $(this).find('div.form-group').each(function () {
                        if ($(this).find('span.field-validation-error').length == 0) {
                            $(this).removeClass('has-error');
                        }
                    });
                }
                else {
                    $(this).find('div.form-group').each(function () {
                        if ($(this).find('span.field-validation-error').length > 0) {
                            $(this).addClass('has-error');
                        }
                    });
                }
            });

            $('form').each(function () {
                $(this).find('div.form-group').each(function () {
                    if ($(this).find('span.field-validation-error').length > 0) {
                        $(this).addClass('has-error');
                    }
                });
            });

        }
    },

    tooltips: {
        init: function () {
            $('.form-group').tooltip({
                selector: "[data-toggle=tooltip]",
                placement: "right",
                container: "body"
            });
            $("[data-toggle=tooltip]").tooltip();
        }
    },
    popovers: {
        init: function () {
            $("[data-toggle=popover]").popover();
        }


    },

    buttons: {
        init: function () {
            $("button[data-loading-text]").each(function () {
                $(this).click(function () {
                    var btn = $(this);
                    btn.button('loading');
                    setTimeout(function () {
                        btn.button('reset')
                    }, 3000);
                });
            });
        }
    },

    files: {
        init: function () {
            $(".fileuploader").each(function () { $(this).customFileInput(); });
        }
    },

    datepickers: {
        init: function () {
            $(".input-group.date").datepicker({
                autoclose: true,
                format: "dd/mm/yyyy"
            });
        }
    },

    checkable: {
        init: function () {
            $(".uxCheck").prettyCheckable();
        }
    },

    init: function () {
        this.dropdowns.init();
        this.validation.init();
        this.tooltips.init();
        this.buttons.init();
        this.files.init();
        this.datepickers.init();
        this.popovers.init();
        this.checkable.init();
    }
};

$(function () { ux.init(); });