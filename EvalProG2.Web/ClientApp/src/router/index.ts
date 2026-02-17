import { createRouter, createWebHistory } from 'vue-router'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: () => import('../views/Startseite.vue'),
    },
    {
      path: '/edit',
      name: 'edit',
      component: () => import('../views/editView.vue'),
    },
    {
      path: '/examiner',
      name: 'IN_Examiner',
      component: ()=>import('../views/IN_Examiner.vue')
    },
    {
      path:'/candidate',
      name:'IN_Candidate',
      component: ()=>import('../views/IN_candidate.vue')
    },
        {
      path:'/discussion',
      name:'IN_Discussion',
      component: ()=>import('../views/IN_discussion.vue')
    },
        {
      path:'/eval_doc',
      name:'IN_EvalDocumentation',
      component: ()=>import('../views/IN_EvalDocumentation.vue')
    },
        {
      path:'/eval_pres',
      name:'IN_EvalPresentation',
      component: ()=>import('../views/IN_EvalPresentation.vue')
    },
        {
      path:'/closingremarks',
      name:'IN_OUT_closing',
      component: ()=>import('../views/IN_OUT_closing.vue')
    },
        {
      path:'/questions',
      name:'IN_Questions',
      component: ()=>import('../views/IN_questions.vue')
    },
  ],
})

export default router
