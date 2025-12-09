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
    {
      path: '/about',
      name: 'about',
      // route level code-splitting
      // this generates a separate chunk (About.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: () => import('../views/AboutView.vue'),
    },
    {
      path: '/IN_Examiner',
      name: 'IN_Examiner',
      component: ()=>import('../views/IN_Examiner.vue')
    },
    {
      path:'/IN_Candidate',
      name:'IN_Candidate',
      component: ()=>import('../views/IN_candidate.vue')
    },
        {
      path:'/IN_Discussion',
      name:'IN_Discussion',
      component: ()=>import('../views/IN_discussion.vue')
    },
        {
      path:'/IN_EvalDocumentation',
      name:'IN_EvalDocumentation',
      component: ()=>import('../views/IN_EvalDocumentation.vue')
    },
        {
      path:'/IN_EvalPresentation',
      name:'IN_EvalPresentation',
      component: ()=>import('../views/IN_EvalPresentation.vue')
    },
        {
      path:'/IN_OUT_closing',
      name:'IN_OUT_closing',
      component: ()=>import('../views/IN_OUT_closing.vue')
    },
        {
      path:'/IN_Questions',
      name:'IN_Questions',
      component: ()=>import('../views/IN_questions.vue')
    },
  ],
})

export default router
