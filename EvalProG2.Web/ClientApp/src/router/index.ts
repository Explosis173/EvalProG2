import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
   {
     path: '/',
     name: 'home',
     component: HomeView,
   },
    // {
    //   path: '/index',
    //   name: 'index',
    //   // route level code-splitting
    //   // this generates a separate chunk (About.[hash].js) for this route
    //   // which is lazy-loaded when the route is visited.
    //   component: () => import('../views/indexView.vue'),
    // },
    {
      path: '/edit',
      name: 'edit',
      component: () => import('../views/editView.vue'),
    },
        {
      path: '/new',
      name: 'new',
      component: () => import('../views/newView.vue'),
    },
       {
      path: '/pruefen',
      name: 'pruefen',
      component: () => import('../views/pruefenView.vue'),
    },
       {
      path: '/Pdoku',
      name: 'Pdoku',
      component: () => import('../views/PdokuView.vue'),
    },
       {
      path: '/Pprojekt',
      name: 'Pprojekt',
      component: () => import('../views/PprojektView.vue'),
    },
       {
      path: '/Pfach',
      name: 'Pfach',
      component: () => import('../views/PfachView.vue'),
    },
       {
      path: '/Pges',
      name: 'Pges',
      component: () => import('../views/PgesView.vue'),
    },
       {
      path: '/Pmund',
      name: 'Pmund',
      component: () => import('../views/PmundView.vue'),
    },
       {
      path: '/tiri',
      name: 'tiri',
      component: () => import('../views/tiriView.vue'),
    },
  ],
})

export default router
