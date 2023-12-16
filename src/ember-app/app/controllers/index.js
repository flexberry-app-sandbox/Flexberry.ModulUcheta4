import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.справочник.caption'),
          title: i18n.t('forms.application.sitemap.справочник.title'),
          children: [{
            link: 'i-i-s-modul-ucheta-директор-l',
            caption: i18n.t('forms.application.sitemap.справочник.i-i-s-modul-ucheta-директор-l.caption'),
            title: i18n.t('forms.application.sitemap.справочник.i-i-s-modul-ucheta-директор-l.title'),
            icon: 'suitcase',
            children: null
          }, {
            link: 'i-i-s-modul-ucheta-клиент-l',
            caption: i18n.t('forms.application.sitemap.справочник.i-i-s-modul-ucheta-клиент-l.caption'),
            title: i18n.t('forms.application.sitemap.справочник.i-i-s-modul-ucheta-клиент-l.title'),
            icon: 'folder open',
            children: null
          }]
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.документ.caption'),
          title: i18n.t('forms.application.sitemap.документ.title'),
          children: [{
            link: 'i-i-s-modul-ucheta-расчет-времени-l',
            caption: i18n.t('forms.application.sitemap.документ.i-i-s-modul-ucheta-расчет-времени-l.caption'),
            title: i18n.t('forms.application.sitemap.документ.i-i-s-modul-ucheta-расчет-времени-l.title'),
            icon: 'calendar',
            children: null
          }, {
            link: 'i-i-s-modul-ucheta-договор-l',
            caption: i18n.t('forms.application.sitemap.документ.i-i-s-modul-ucheta-договор-l.caption'),
            title: i18n.t('forms.application.sitemap.документ.i-i-s-modul-ucheta-договор-l.title'),
            icon: 'building',
            children: null
          }]
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.прочее.caption'),
          title: i18n.t('forms.application.sitemap.прочее.title'),
          children: [{
            link: 'i-i-s-modul-ucheta-услуги-l',
            caption: i18n.t('forms.application.sitemap.прочее.i-i-s-modul-ucheta-услуги-l.caption'),
            title: i18n.t('forms.application.sitemap.прочее.i-i-s-modul-ucheta-услуги-l.title'),
            icon: 'building',
            children: null
          }]
        }
      ]
    };
  }),
})