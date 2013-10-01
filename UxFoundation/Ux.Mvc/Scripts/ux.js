var dropdowns = {
	init: function () {
		$("select").select2();
	}
}

var validation = {
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
}

var tooltips = {
	init: function () {
		$('.form-group').tooltip({
			selector: "[data-toggle=tooltip]",
			placement: "right",
			container: "body"
		});

	}
}

var buttons = {
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
}

var files = {
    init: function () {
        $(".fileuploader").each(function () { $(this).customFileInput(); });
    }
};

var datepickers = {
    init: function () {
        $(".input-group.date").datepicker({
            autoclose: true,
            format: "dd/mm/yyyy"
        });
    }
}

$(function () {
	dropdowns.init();
	validation.init();
	tooltips.init();
	buttons.init();
	files.init();
	datepickers.init();
});